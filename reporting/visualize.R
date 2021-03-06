library("jsonlite", quietly=T, verbose=F, warn.conflicts=FALSE)
library("ggplot2",quietly=T, verbose=F, warn.conflicts=FALSE)
library("plyr", quietly=T, verbose=F, warn.conflicts=FALSE)
source("functions.R")
source("plot.R")
source("constants.R")

args <- commandArgs(trailingOnly = TRUE)
configPath <- args[1]

results <-read.csv2(resultsPath, header=TRUE, row.names = NULL)

config <- fromJSON(configPath)
  
index <- 0
settings <- PlotSettings()
uniqueScenarios <- unique(results$Model)
  
if (config$Dimensions$Groups$Tool){
  metric <- "Time"
  subData1 <- subset(results, MetricName == metric)
  subData1$MetricValue <- subData1$MetricValue * (10**-6)
  
  uniqueViews <- unique(subData1$Transformation)
  settings <- setGroup(settings, "Tool")
  for(view in uniqueViews){
    subData2 <- subset(subData1, Transformation==view)
    
    if (config$Dimensions$X_Dimensions$Model){
      title <- paste("Code Generator", view)
      settings <- setTitle(settings, title)
      settings <- setDimensions(settings, "Model", "MetricValue")
      settings <- setLabels(settings, "Model", "Time (ms)")
      settings <- setAxis(settings, "Discrete", yAxis)
      for (extension in config$Extension){
        fileName <- paste(rootPath, view, "-GroupBy-Tool-",metric, ".", extension, sep='')
        savePlot(subData2, settings, fileName)
      }
      write.csv(ddply(subData2, c("Tool", "Model"), summarise, N=length(MetricValue), mean=mean(MetricValue), sd=sd(MetricValue)), file = paste(rootPath, view, "-GroupBy-Tool-",metric, ".csv", sep=''))
    }
  }
}