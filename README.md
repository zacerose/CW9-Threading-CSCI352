# CW9: Threading
Name: Zachary Rose  
Date: 3/2/2023  
Class: CSCI 352

Uses threads and the Monte Carlo method to estimate pi using a random number generator. User inputs number of throws and threads to use. 

## Required Files
* CW9-Threading/ --> directory containing the project files
* CW9-Threading.sln --> Visual Studio solution file
* Testing results/ --> Directory containing raw data from speed and accuracy testing of algorithm. Summarized results written below in README.
## Program Usage
To launch the program, clone the repository in Visual Studio and run by pressing "Start".  
When prompted, enter an integer for the number of throws for each thread and an integer for the number of threads to run.  
Keep input within the bounds of a 32 bit positive integer.

## Design Decisions
* No input parsing was added, as it seemed beyond the scope of this project.
* I changed everything related to the int holding the number of hits to a long in order to faciliate larger amounts of threads without integer overflow.
* Added a stopwatch to allow user to get a feel for which tests are faster than others.
## Attempted extra credit
  - Added in timing to output
  - Collected results from testing for accuracy and speed of the algorithm by changing number of darts and number of threads, respectively.
# Testing results
Collated from raw results on a single computer during a single testing period, these are the results I've inferred from the timing and predicted pi value, as can be seen in Testing results/ directory.
## Accuracy
 - While only changing the number of darts to be thrown, a clear positive trend can be seen between increasing the number of darts thrown and approaching the expected value of pi, 3.14159265...
## Speed
 - While keeping the number of darts thrown exactly the same, the fastest results were between 10-20 threads. Increasing and decreasing from there slows the results, and increasing too far is shown to be a negative. 
 - Raw output in Testing results/ is sorted from shortest to longest runtime. 

