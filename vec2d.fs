module vec2d

 let len (vec:float*float) =
  sqrt((fst vec)**2.0 + (snd vec)**2.0)


 let ang (vec:float*float)=
  let x = (fst vec)
  let y = (snd vec)
  abs (atan2 y x)


 let scale (s:float) (vec:float*float) =
  let x = s*(fst vec)
  let y = s*(snd vec)
  x,y


 let add (vec1:float*float) (vec2:float*float) =
  let x =((fst vec1)+(fst vec2))
  let y =((snd vec1)+(snd vec2))
  x,y


 let dot (vec1:float*float) (vec2:float*float) =
  let x =((fst vec1)*(fst vec2))
  let y =((snd vec1)*(snd vec2))
  x+y