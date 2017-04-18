# NBS Keynote Files

There are a number of options to aid the annotation of drawings. The best of these is to use a specific NBS software solution - such as our [ArchiCAD](https://www.thenbs.com/services/our-tools/plug-in-for-graphisoft-archicad), [Vectorworks](http://constructioncode.blogspot.co.uk/2013/10/nbs-plug-in-for-vectorworks-2014.html) and [Revit](https://www.thenbs.com/services/our-tools/nbs-plug-in-for-autodesk-revit) plugins, which allow you to easily add annotations  that are relevant to the particular project.

That said, we recognise that a number of practices would still like to work with the "keynote" style functionality on certain projects. This GitHub repository makes 3 tab-separated ASCII text keynote files available for download. These files can be opened in Microsoft Excel and converted to other formats to work with your preferred design tool.

### UK\_NBS\_Uniclass2015\_04\_18.txt (553 KB) [(Download)](https://raw.githubusercontent.com/theNBS/KeynotesFiles/master/Keynote%20Files/UK_NBS_Uniclass2015_04_18.txt)
This file has all Uniclass2015 listings covering the following tables:

* (Co) Complexes
* (En) Entities
* (Ac) Activities
* (SL) Spaces/locations
* (EF) Elements/functions
* (Ss) Systems
* (Pr) Products
* (Zz) CAD
* (CA) Construction Aids*
* (FI) Form of Information*

\* Note that tables marked with an asterisk are currently in Beta status with industry consultation ongoing

![Using Uniclass2015 for keynoting](https://raw.githubusercontent.com/theNBS/KeynotesFiles/master/Resources/KeynotesUniclass2015.gif)

Classification codes in this file go five levels deep.

### UK\_NBS\_Uniclass2_2012.txt (270 KB) [(Download)](https://raw.githubusercontent.com/theNBS/KeynotesFiles/master/Keynote%20Files/UK_NBS_Uniclass2_2012.txt)
This file has all Uniclass 2 Work Result listings and clause numbers. A screen shot is shown below:

![Using Uniclass 2 Work Results table for keynoting](https://raw.githubusercontent.com/theNBS/KeynotesFiles/master/Resources/KeynotesUniclass2.gif)

Classification codes in this file go three levels deep. In addition, the file only includes system outline clause titles and manufacturer product clause titles, making it more concise as workmanship clause titles are excluded.

### NBS\_UK\_CAWs_2012.txt (462 KB) [(Download)](https://raw.githubusercontent.com/theNBS/KeynotesFiles/master/Keynote%20Files/UK_NBS_CAWs_2012.txt)
This file has all Common Arrangement of Work Sections (CAWS) listings and clause numbers. A screen shot is shown below:

![Using CAWs for keynoting](https://raw.githubusercontent.com/theNBS/KeynotesFiles/master/Resources/KeynotesCAWS.gif)

Classification codes in this file go two levels deep, for example L and then L10. Note that the intermediate level of L1 is NOT included.

## Uniclass2015 Keynote File Generator

This repository also includes a utility written in C# which generates the tab-separated Uniclass2015 keynotes file from a JSON feed on the NBS BIM Toolkit.
