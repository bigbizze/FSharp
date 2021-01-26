namespace FSharp
open UnityEngine;

type Basic() =
    inherit MonoBehaviour()
    member this.Start() = Debug.Log("Bitch")
//module Say =
//    let hello name =
//        printfn "Hello %s" name
