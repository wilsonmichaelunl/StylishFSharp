type MyRecord =
    { String: string
      Int: int }

let recordA =
    { String = "Hi Clouds"; Int = 99 }

let recordB = { recordA with String = "Hello sky" }
