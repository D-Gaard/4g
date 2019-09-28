open vec2d

//White-box testing:
//len
printfn "White-box testing af biblioteket vec2d"
printfn "Unit: len"
//x,y er negative
printfn "    %5b: Negativ length test" (len ((-3.0),(-4.0)) =5.0 )
 //x,y er 0
printfn "    %5b: Nul length test" (len (0.0,0.0) = 0.0)
//x,y er positive
printfn "    %5b: Positiv length test" (len (3.0,4.0) = 5.0)


//ang
printfn "Unit: ang"
 //x,y er negative
printfn "    %5b: Negativ ang test" (ang (-3.0,-4.0) = abs(atan2 -4.0 -3.0))
 //x,y er 0
printfn "    %5b: Nul ang test" (ang (0.0,0.0) =0.0)
 //x,y er positive
printfn "    %5b: Positiv ang test" (ang (3.0,4.0) = atan2 4.0 3.0)

//scale
printfn "Unit: scale"
 //x,y er negative s er positiv
printfn "    %5b: x,y er negative, s er positiv scale test" ((scale 5.0 (-3.0,-4.0)) =(-15.0,-20.0 ))
 //x,y er 0, s er positiv
printfn "    %5b: x,y er 0, s er positiv scale test" ((scale 5.0 (0.0,0.0)) =(0.0,0.0))
 //x,y,s er positiv
printfn "    %5b: x,y,s er positiv scale test" ((scale 5.0 (3.0,4.0)) =(15.0,20.0 ))
 //x,y,s er negativ
printfn "    %5b: x,y,s er negativ scale test" ((scale -5.0 (-3.0,-4.0)) =(15.0,20.0 ))
 //x,y er 0, s er negativ
printfn "    %5b: x,y er 0, s er negativ scale test" ((scale -5.0 (0.0,0.0)) =(0.0,0.0))
 //x,y er positive,s er negativ
printfn "    %5b: x,y er positive, s er negativ scale test" ((scale -5.0 (3.0,4.0)) =(-15.0,-20.0 ))
 //x,y er negativ s er 0
printfn "    %5b: x,y er negativ s er 0 scale test" ((scale 0.0 (-3.0,-4.0)) = (0.0,0.0))
 //x,y, s er 0
printfn "    %5b: x,y, s er 0 scale test" ((scale 0.0 (0.0,0.0)) =(0.0,0.0))
  //x,y er positiv s er 0
printfn "    %5b: x,y er positiv, s er 0 scale test" ((scale 0.0 (3.0,4.0)) =(0.0,0.0 ))

printfn "Unit: add"
//add
// v1,v2 er positve
printfn "    %5b: Positiv add test" (add (3.0,4.0) (3.0,4.0) =(6.0, 8.0) )
 //v1,v2 er 0
printfn "    %5b: Nul add test" (add (0.0,0.0) (0.0,0.0) =(0.0,0.0))
//v1,v2 er negative
printfn "    %5b: Negativ add test" (add (-3.0,-4.0) (-3.0,-4.0) =(-6.0, -8.0) )
 //v1 er positiv v2 er negativ
printfn "    %5b: v1 positiv, v2 negativ add test" (add (3.0,4.0) (-3.0,-4.0) =(0.0, 0.0) )

//dot
printfn "Unit: dot"
//v1,v2 er positve
printfn "    %5b: v1, v2 er positiv dot test" (dot (3.0,4.0) (3.0,4.0) =25.0 )
//v1,v2 er 0
printfn "    %5b: v1 og v2 er nul dot test" (dot (0.0,0.0) (0.0,0.0) =0.0)
//v1,v2 er negative
printfn "    %5b: v1 og v2 negative dot test" (dot (-3.0,-4.0) (-3.0,-4.0) =25.0 )
//v1 er positiv v2 er negativ
printfn "    %5b: v1 er positiv, v2 negativ dot test" (dot (3.0,4.0) (-3.0,-4.0) = -25.0)
