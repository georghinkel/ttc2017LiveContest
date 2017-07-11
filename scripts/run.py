#!/usr/bin/python
"""
@author: Zsolt Kovari, Georg Hinkel

"""
import argparse
import os
import shutil
import subprocess
import sys
import ConfigParser
import json
from subprocess import CalledProcessError
import filecmp

BASE_DIRECTORY = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
print "Running benchmark with root directory " + BASE_DIRECTORY

class JSONObject(object):
    def __init__(self, d):
        self.__dict__ = d


def build(conf, skip_tests=False):
    """
    Builds all solutions
    """
    for tool in conf.Tools:
        config = ConfigParser.ConfigParser()
        config.read(os.path.join(BASE_DIRECTORY, "solutions", tool, "solution.ini"))
        set_working_directory("solutions", tool)
        if skip_tests:
            subprocess.check_call(config.get('build', 'skipTests'), shell=True)
        else:
            subprocess.check_call(config.get('build', 'default'), shell=True)


def benchmark(conf):
    """
    Runs measurements
    """
    header = os.path.join(BASE_DIRECTORY, "output", "header.csv")
    result_file = os.path.join(BASE_DIRECTORY, "output", "output.csv")
    if os.path.exists(result_file):
        os.remove(result_file)
    shutil.copy(header, result_file)
    os.environ['Runs'] = str(conf.Runs)
    for r in range(0, conf.Runs):
        os.environ['RunIndex'] = str(r)
        for tool in conf.Tools:
            config = ConfigParser.ConfigParser()
            config.read(os.path.join(BASE_DIRECTORY, "solutions", tool, "solution.ini"))
            set_working_directory("solutions", tool)
            os.environ['Tool'] = tool
            try:
                os.mkdir(os.path.abspath(os.path.join(BASE_DIRECTORY, "results", tool)))
            except Exception:
                pass
            for model in conf.Models:
                os.environ['Model'] = model
                os.environ['Input'] = os.path.abspath(os.path.join(BASE_DIRECTORY, "models", model + ".xmi"))
                for tr in conf.Transformations:
                    os.environ['Transformation'] = tr
                    full_result_path = os.path.abspath(os.path.join(BASE_DIRECTORY, "results", tool, model + tr))
                    os.environ['Output'] = full_result_path + ".xmi"
                    print("Running benchmark: tool = " + tool + ", model = " + model +
                          ", transformation = " + tr)
                    try:
                        output = subprocess.check_output(config.get('run', tr), shell=True)
                        with open(result_file, "ab") as file:
                            file.write(output)
                    except CalledProcessError:
                        print("Program exited with error")
                    try:
                        subprocess.check_output([os.path.join(BASE_DIRECTORY, "solutions", "NMF", "bin", "NMFCodeGenerator.exe"),
                                                 "print"])
                    except CalledProcessError:
                        pass
                    expected = os.path.abspath(os.path.join(BASE_DIRECTORY, "expected_results", model + "_code" + tr + ".txt"))
                    if not filecmp.cmp(full_result_path + ".txt", expected):
                        print("Results are different from the expected results")



def clean_dir(*path):
    dir = os.path.join(BASE_DIRECTORY, *path)
    if os.path.exists(dir):
        shutil.rmtree(dir)
    os.mkdir(dir)


def set_working_directory(*path):
    dir = os.path.join(BASE_DIRECTORY, *path)
    os.chdir(dir)


def visualize():
    """
    Visualizes the benchmark results
    """
    clean_dir("diagrams")
    set_working_directory("reporting")
    subprocess.call(["Rscript", "visualize.R", os.path.join(BASE_DIRECTORY, "config", "reporting.json")])


if __name__ == "__main__":
    parser = argparse.ArgumentParser()
    parser.add_argument("-b", "--build",
                        help="build the project",
                        action="store_true")
    parser.add_argument("-m", "--measure",
                        help="run the benchmark",
                        action="store_true")
    parser.add_argument("-s", "--skip-tests",
                        help="skip JUNIT tests",
                        action="store_true")
    parser.add_argument("-v", "--visualize",
                        help="create visualizations",
                        action="store_true")
    parser.add_argument("-t", "--test",
                        help="run test",
                        action="store_true")
    args = parser.parse_args()


    set_working_directory("config")
    with open("config.json", "r") as config_file:
        config = json.load(config_file, object_hook = JSONObject)

    if args.build:
        build(config, args.skip_tests)
    if args.measure:
        benchmark(config)
    if args.test:
        build(config, False)
    if args.visualize:
        visualize()

    # if there are no args, execute a full sequence
    # with the test and the visualization/reporting
    no_args = all(val==False for val in vars(args).values())
    if no_args:
        build(config, False)
        benchmark(config)
        visualize()
