testScript <- function (message) { print (message) }

args <- commandArgs(trailingOnly = TRUE)
message <- as.character(args[1])
testScript(message)
