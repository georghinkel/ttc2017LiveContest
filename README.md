# TTC 2017 Live Contest

This repository contains the case resources of the TTC 2017 Live contest.

## Case description

The `docs/2017_TTC_Live.pdf` file contains the case description.

## Prerequisites to run the benchmark framework

* Python 2.7 or higher
* R
* * jsonlite
* * ggplot2
* .NET 4.5.1 to run correctness checks (the model printer uses NMF). .NET 4.5.1 in turn requires at least Windows Vista SP1.

## Solution Prerequisites

* NMF: .NET Framework 4.5.1 and MSBuild on the path

## Using the framework

The `scripts` directory contains the `run.py` script which is used for the following purposes:
* `run.py -b` -- builds the projects
* `run.py -b -s` -- builds the projects without testing
* `run.py -m` -- runs the benchmark
* `run.py -v` -- visualizes the results of the latest benchmark

The `config` directory contains the configuration for the scripts:
* `config.json` -- configuration for the model generation and the benchmark
* `reporting.json` -- configuration for the visualization

### Running the benchmark

The script runs the benchmark for the given number of runs, for the specified tools and models

The benchmark results are stored in a CSV file. The header for the CSV file is stored in the `output/header.csv` file.

## Reporting and visualization

Make sure you read the `README.md` file in the `reporting` directory and install all the requirements for R.

## Running the example solution

To run the benchmark framework, simply run the `run.py` script in the scripts folder with your Python interpreter. The working directory is not important.

## Implementing the benchmark for a new tool

To implement a tool, you need to 

1. create a new directory in the solutions directory and give it a suitable name
1. implement the code generators :)
1. add a `solution.ini` file that specifies the exact command that is run for your solution
1. add your tool to the configuration file `config.json`. The name you enter there must match the name of the directory created earlier.
