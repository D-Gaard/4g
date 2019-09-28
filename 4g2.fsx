open vec2d
open System 

///<summary> Funktionen beregner l�ngden af et polygon med n antal punkter </summary>
///<param name="n"> Antal punkter  </param>
///<returns> L�ngden af polygonet  </returns>
let polyLen (n:int) : float =
  
  let vec1 = 1.0,0.0 //F�rste vektor har altid disse koordinater
  let vinkel =(2.0*(Math.PI))/(float n) //bereger vinkel mellem x og vektor 2
  let vec2 = (-1.0*(cos vinkel),-1.0*(sin vinkel)) //beregner vektor 2's koordinater ud fra vinklen og inverterer dem
  let vecNy = (add vec1 vec2) //bruger add funktionen til teknisk at tr�kke de 2 vektorer fra hinanden da vec2's koordinater er blevet inverterede
  let res:float = float(vec2d.len vecNy) //finder l�ngden af den nye vektor
  res*(float n)

printfn "%A" (polyLen 100)
printfn "%A" (polyLen 3)
printfn "%A" (polyLen 4)
printfn "%A" (polyLen 10000)

printfn "  n | Omkreds Poly | Procentvis afvigelse"
printfn "------------------------------------------"
for i in 2..10 do
  let omk = 3.141592653589*1.0*2.0
  printfn "%3i | %6f     | %6f " i (polyLen i) ((polyLen i)/omk*100.0)

for i in 15..5..200 do
  let omk = 3.141592653589*1.0*2.0
  printfn "%3i | %6f     | %6f " i (polyLen i) ((polyLen i)/omk*100.0)

//Det ses at n�r n g�r mod uendelig, s� g�r omkredsen af polygonet mod omkredsen af enhedscirklen (2*pi)