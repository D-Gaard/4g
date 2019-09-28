module vec2d

/// A 2 dimensional vector library.
/// Vectors are represented as pairs of floats


/// The length of a vector
///<summary> Funktionen beregner længden af en vektor, ved input af en tuple med typerne float*float </summary>
///<param name="vec"> Vektoren </param>
///<returns> Længden af vektoren </returns>
 val len : float*float -> float


/// The angle of a vector
///<summary>Funktionen beregner vinklen af en vektor, ved input af en tuple med typerne float*float </summary>
///<param name="vec"> Vektoren </param>
///<returns> Vinklen af vektoren </returns>
 val ang : float*float -> float


/// Multiplication of a float and a vector
///<summary> Funktionen skalerer en vektor ved gange en værdi på vektoren, ved input af en skaleringsværdi og en tuple med typerne float*float </summary>
///<param name="s"> Skalerings værdien </param>
///<param name="vec"> Vektoren </param>
///<returns> Den skalerede vektor </returns>
 val scale : float -> float*float -> float*float


/// Addition of two vectors
///<summary> Funktionen lægger to vektorer sammen ved input af to tupler med typerne float*float </summary>
///<param name="vec1"> Vektor 1 </param>
///<param name="vec2"> Vektor 2 </param>
///<returns> Summen af to vektorer </returns>
 val add : float*float -> float*float -> float*float


/// Dot product of two vectors
///<summary> Funktionen beregner skalarproduktet af to vektorer ved input af to tupler med typerne float*float </summary>
///<param name="vec1"> Vektor 1 </param>
///<param name="vec2"> Vektor 2 </param>
///<returns> Skalarproduktet(dot produktet) af to vektorer </returns>
 val dot : float*float -> float*float -> float