# ExcelUnity
## What is Excel Unity?


It is an editor addon for Unity that uses an excel file to generate prefabs. Prefabs are assets templates used in Unity. 

The excel format so far tested is Ods.

## What is Unity?
Unity is a game engine. Here is the link https://unity3d.com/


## What is GemBox
GemBox is a C# excelsheet library that made this possible. here is a link http://www.gemboxsoftware.com/


## Using Excel Unity


There is two components, a template gameobject and excel file. In addition there is an output file path need for all the generated prefab to go,


The excel file must follow the following rules.


The first row is the names of the methods.

The first cell in each following row is used to name the prefab.

Each cell in the row is applied to its corresponding column field.

Any gaps between rows will end the program.


The template Game Object is the base on which the excel work on, and need a method that's the same name as the column heads that take one parameter that allows the values of that column 


###Template Game Object


Method 1 (String name)//Need to be string for name of Prefab. 

Method 2(Type 2  v)

Method 3(Type 3 v)

Method 4(Type 4 v)


## Excel File Format



Method 1           Method 2      Method 3       Method 4

Prefab Name/Value  Type 2 Value  Type 3 Value  Type 4 Value

Prefab Name/Value  Type 2 Value  Type 3 Value  Type 4 Value

//blank


The template object must have all the methods in 

## Setup

1. Download GemBox.SpreadSheet
2. Make a Unity Project(See Unity)
3. Make a Editor and Plugins folder in the Unity Project Assets folder
4. Copy GemBox.SpreadSheet in the Pigun folder. (Only Net20)
5. Copy in ExcelUnityWindow.cs into Editor folder.



## Errors and Future Goals 


- [ ] At the moment any cell with a formula return a string instead of the calculated value. There is a method call that should have fixed this but isn’t. More research is needed.


- [ ] Create a way for GameObject Template to not need the “name” method.  
