This C# program is based on an olympiad exercise gave to students couple years ago.


SCENARIO :
Given a 2d array of width X and height Y storing 0s and 1s.

Example #1:

![image](https://user-images.githubusercontent.com/33300046/153735709-d00683d7-dd09-4abe-93ad-4c159993a071.png)

Example #2 (new random grid, same user selected point(4,9)):

![image](https://user-images.githubusercontent.com/33300046/153735864-545fe674-d38e-49db-9b14-264aa2f8d6d2.png)

0s being a color (ex: white)
1s being another color (ex: light gray)

User has to input a point(x,y) of the array. 
Program has to paint (represented with 2s (gray)) the array cell and its next neighbors (up, down, left, right),
the 2nd next neighbors, etc until every neighbors have been painted.


PROJECTS:
2 C# projects have been made.
First  in Windows Form app  :: Recursive_Painting/RecursiveCallPainting/F_RecursivePainting.cs 
Second in terminal directly :: Recursive_Painting/RecursiveCallPaintingNoUI/Program.cs 


ADDITIONS:
Grid size is variable.
Grid is randomly generated.
Input are verified to make sure they aren't out of range or NaN (not a number).


INFOS:

//General comments on the logic of the program

///Comments regarding UI 
