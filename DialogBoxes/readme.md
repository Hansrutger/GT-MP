# Dialog Boxes (DBX)

## Introduction
These were created to make it easier to show players "templated dialogs". There are a few different ones and they are per-player customizable when it comes to coloring (you can change the color for whichever player whenever throughout their session). 


## How to install?
You simply use the implement the javascript files into your project, along with the csharp file and include them in the meta.xml file. The following files that are in this repository must be included:
- DBXHandler.cs
- Text_Scrollbar.js


## How to use them?
There are different types of dialogs, but most formats are "dbx_type_subtype":

### Types and their Subtypes
- Text
  - Scrollbar ('dbx_text_scroll')
  - Plain (not implemented)
- Options
  - Scrollbar (not implemented)


### Usage
In order to display a dialog box all you have to do is to trigger the correct type of dialog box from the server-side through "triggerClientEvent". An example:
```csharp
API.triggerClientEvent(Client player, ...);
```

### dbx_text_scroll
```csharp
API.triggerClientEvent(Client player, string dialog_type, string function,
  string title, string text, int buttons, string buttonName1, string buttonNameN,
  string textfieldTxt1, string textfieldTxtN);
```
- Client player: is the player that will be seeing the dialog
- string dialog_type: would be which dialog (look above on the type-list)
- string function: this is the eventname that will be sent back to the server-side once the player chooses to press a button
- string title: text of the title
- string text: text of the main context (below title)
- int buttons: to tell how many buttons you wish to have (minimum 1, maximum 3)
- string buttonName1: the button text of the first button
- string buttonNameN: the button text of the N-th button
- string textfieldTxt1: the text of the first textfield in the scrollbar box
- string textfieldTxtN: the text of the N-th textfield in the scrollbar box



***
***
***

## MIT License
Copyright (c) 2017 Hansrutger

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
