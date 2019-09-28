module vec2dv2

///<summary> Funktionen beregner længden af en vektor, ved input af vektorens x- og y koorinater </summary>
///<param name="x"> Vektorens x-koordinat </param>
///<param name="y"> Vektorens y-koordinat </param>
///<returns> Længden af vektoren </returns>
 val len : float -> float -> float

///<summary>Funktionen beregner vinklen af en vektor, ved input af vektorens x- og y koorinater </summary>
///<param name="x"> Vektorens x-koordinat </param>
///<param name="y"> Vektorens y-koordinat </param>
///<returns> Vinklen af vektoren </returns>
 val ang : float -> float -> float


///<summary> Funktionen skalerer en vektor ved gange en værdi på vektoren, ved input af en skaleringsværdi og vektorens x- og y koorinater </summary>
///<param name="s"> Skalerings værdien </param>
///<param name="x"> Vektorens x-koordinat </param>
///<param name="y"> Vektorens y-koordinat </param>
 val scale : float -> float -> float -> float array


///<summary> Funktionen lægger to vektorer sammen ved input af de 2 vektores x- og y koordinater </summary>
///<param name="x1"> 1. Vektors x-koordinat </param>
///<param name="y1"> 1. Vektors y-koordinat </param>
///<param name="x2"> 2. Vektors x-koordinat </param>
///<param name="y2"> 2. Vektors y-koordinat </param>
///<returns> Summen af to vektorer </returns>
 val add : float -> float -> float -> float -> float array


///<summary> Funktionen beregner skalarproduktet af to vektorer ved input af de 2 vektorers x- og y koordinater </summary>
///<param name="x1"> 1. Vektors x-koordinat </param>
///<param name="y1"> 1. Vektors y-koordinat </param>
///<param name="x2"> 2. Vektors x-koordinat </param>
///<param name="y2"> 2. Vektors y-koordinat </param>
///<returns> Skalarproduktet(dot produktet) af to vektorer </returns>
 val dot : float -> float -> float -> float -> float
 
//Den helt store forksel, er at når der skal returneres en vektor, så er man nødt til at returnere et 2 langt array, istedet for en tuple.
//Dette betyder altså at man skal bruge A.[0] for x og A.[1] for y, frem for blot at kunne anvende fst og snd, til at få hver af de 2 koordinater.
//Implementations filen vil se ud på nogenlunde samme måde, men når man skal bruge funktionerne, så bliver det mere besværligt, da man skal angive både x og y som parametre
//frem for blot at kunne give tuplen som en parameter. 
