# NBS Keynote Files

There are a number of options to aid the annotation of drawings. The best of these is to use a specific NBS software solution - such as our ArchiCAD, Vectorworks and Revit plugins, which allow you to easily add annotations  that are relevant to the particular project.

That said, we recognise that a number of practices would still like to work with the "keynote" style functionality on certain projects. This GitHub repository makes 3 tab-separated ASCII text keynote files available for download. These files can be opened in Microsoft Excel and converted to other formats to work with the user's preferred design tool.

### UK\_NBS\_Uniclass2015.txt (553 KB)
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

### UK\_NBS\_Uniclass2_2012.txt (270 KB)
This file has all Uniclass 2 Work Result listings and clause numbers. A screen shot is shown below:

![Using Uniclass 2 Work Results table for keynoting](http://2.bp.blogspot.com/-JWo5l2MIR60/UKJrMK4BRKI/AAAAAAAACk4/hI_sVhZZO_g/s640/Keynotes02.gif)

Classification codes in this file go three levels deep. In addition, the file only includes system outline clause titles and manufacturer product clause titles, making it more concise as workmanship clause titles are excluded.

### NBS\_UK\_CAWs_2012.txt (462 KB)
This file has all Common Arrangement of Work Sections (CAWS) listings and clause numbers. A screen shot is shown below:

![Using CAWs for keynoting](http://1.bp.blogspot.com/-bIhMnva1VNU/UKJrA4UCKzI/AAAAAAAACkw/NAoH78F4Va8/s1600/Keynotes01.gif)

Classification codes in this file go two levels deep, for example L and then L10. Note that the intermediate level of L1 is NOT included.

## Uniclass2015 Keynote File Generator

This repository also includes a utility written in C# which generates the tab-separated Uniclass2015 keynotes file from a JSON feed on the NBS BIM Toolkit.