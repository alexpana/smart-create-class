Smart Create Class for C++
==========================
This extension allows the user to create c++ classes by using the context menu in the solution explorer. The classes are created in the folder represented by the filter hierarchy.

Usage
=====
1. Use the context menu to open up the class creation dialog.
![Contextual menu for adding classes](https://raw.githubusercontent.com/alexpana/smart-create-class/master/images/step1.png)

2. Select the class template. Available templates are: cocos2d Node, empty class or empty files.
![Create class dialog](https://raw.githubusercontent.com/alexpana/smart-create-class/master/images/step2.png)

3. The header / source files are generated in the correct directory and added to the solution.
![Result](https://raw.githubusercontent.com/alexpana/smart-create-class/master/images/step3.png)

Notice
======
Currently only works with cocos2d-x projects, since the the output folder is based on the cocos2d-x templates.
