This C# program is based on an olympiad exercise gave to students couple years ago.

SCENARIO :
Given a 2d array of width X and height Y storing 0s and 1s.
Example:
Initial array                                  Result array
Randomly generated 10x10 Array :            => User input (4,9)
| 1 | 1 | 0 | 1 | 1 | 1 | 0 | 0 | 0 | 1 |      | 1 | 1 | 0 | 1 | 1 | 1 | 0 | 0 | 0 | 1 |     
| 1 | 1 | 0 | 1 | 0 | 1 | 1 | 0 | 0 | 0 |      | 1 | 1 | 0 | 1 | 0 | 1 | 1 | 0 | 0 | 0 |
| 1 | 1 | 1 | 1 | 0 | 1 | 0 | 1 | 1 | 0 |      | 1 | 1 | 1 | 1 | 0 | 1 | 0 | 1 | 1 | 0 |
| 0 | 1 | 1 | 1 | 1 | 1 | 0 | 0 | 1 | 0 |      | 0 | 1 | 1 | 1 | 1 | 1 | 0 | 0 | 1 | 0 |
| 0 | 1 | 1 | 0 | 1 | 0 | 1 | 1 | 0 | 0 |      | 0 | 1 | 1 | 0 | 1 | 0 | 1 | 1 | 0 | 0 |
| 0 | 1 | 0 | 0 | 1 | 1 | 0 | 0 | 0 | 0 |      | 0 | 1 | 0 | 0 | 1 | 1 | 0 | 0 | 0 | 0 |
| 1 | 0 | 0 | 1 | 0 | 0 | 1 | 0 | 0 | 1 |      | 1 | 0 | 0 | 2 | 0 | 0 | 1 | 0 | 0 | 1 |
| 1 | 0 | 0 | 1 | 1 | 0 | 0 | 0 | 0 | 0 |      | 1 | 0 | 0 | 2 | 2 | 0 | 0 | 0 | 0 | 0 |
| 1 | 0 | 1 | 1 | 1 | 1 | 1 | 0 | 0 | 1 |      | 1 | 0 | 2 | 2 | 2 | 2 | 2 | 0 | 0 | 1 |
| 1 | 1 | 0 | 1 | 1 | 1 | 0 | 1 | 1 | 1 |      | 1 | 1 | 0 | 2 | 2 | 2 | 0 | 1 | 1 | 1 |
                 ^^^=(4,9)                                      ^^^=(4,9)

0s being a color (ex: white)
1s being another color (ex: light gray)

User has to input a point(x,y) of the array. 
Program has to paint (represented with 2s) the array cell and its next neighbors (up, down, left, right),
the 2nd next neighbors, etc until every neighbors have been painted.

PROJECTS:
2 C# projects have been made.
First in Windows Form app.
Second in terminal directly.

ADDITIONS:
Grid size is variable.
Grid is randomly generated.
Input are verified to make sure they aren't out of range or NaN (not a number).

INFOS:
//General comments on the logic of the program
///Comments regarding UI 
