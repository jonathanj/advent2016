[<EntryPoint>]
let main argv =
  let fn =
    match (Array.map int argv) with
    | [|2020;  1|] -> Some AdventOfCode.Year2020.Day1.main
    | [|2020;  2|] -> Some AdventOfCode.Year2020.Day2.main
    | [|2020;  3|] -> Some AdventOfCode.Year2020.Day3.main
    | [|2020;  4|] -> Some AdventOfCode.Year2020.Day4.main
    | [|2020;  5|] -> Some AdventOfCode.Year2020.Day5.main
    | [|2020;  6|] -> Some AdventOfCode.Year2020.Day6.main
    | [|2020;  7|] -> Some AdventOfCode.Year2020.Day7.main
    | [|2020;  8|] -> Some AdventOfCode.Year2020.Day8.main
    | [|2020;  9|] -> Some AdventOfCode.Year2020.Day9.main
    | [|2020; 10|] -> Some AdventOfCode.Year2020.Day10.main
    | [|2020; 11|] -> Some AdventOfCode.Year2020.Day11.main
    | [|2020; 12|] -> Some AdventOfCode.Year2020.Day12.main
    | [|2020; 13|] -> Some AdventOfCode.Year2020.Day13.main
    | [|2020; 14|] -> Some AdventOfCode.Year2020.Day14.main
    | [|2020; 15|] -> Some AdventOfCode.Year2020.Day15.main
    | [|2020; 16|] -> Some AdventOfCode.Year2020.Day16.main
    | [|2020; 17|] -> Some AdventOfCode.Year2020.Day17.main
    | [|2020; 18|] -> Some AdventOfCode.Year2020.Day18.main
    | [|2020; 19|] -> Some AdventOfCode.Year2020.Day19.main
    | [|2020; 21|] -> Some AdventOfCode.Year2020.Day21.main
    | [|2020; 22|] -> Some AdventOfCode.Year2020.Day22.main
    | [|2020; 23|] -> Some AdventOfCode.Year2020.Day23.main
    | [|2020; 24|] -> Some AdventOfCode.Year2020.Day24.main
    | [|2020; 25|] -> Some AdventOfCode.Year2020.Day25.main
    | _ -> None

  match fn with
    | Some fn -> fn (); 0
    | _ -> printfn "Usage: <year> <day>"; 1