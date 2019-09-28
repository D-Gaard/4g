Gå til mappe scr i kommandoprompten, dernæst compiles biblioteket med kommandoen fsharpc -a vec2d.fs vec2d.fsi. 
Derefter kan .fsx filer compileres sammen med biblioteket, med kommando fsharpc -r vec2d.dll "filnavn".fsx.
Der dannes en exe-fil som kan køres med kommando mono "filnavn".exe.
