﻿module Config

open Microsoft.Xna.Framework

type ImageConfig =
    { PixelSize: int * int
      Rows: int
      Columns: int
      Offset: Vector2
      TextureName: string }

type AnimationConfig =
    { Index: int
      Looping: bool
      Speed: int
      Columns: int
      }

type SpriteConfig =
    { Images: ImageConfig list
      InitAnimation: AnimationConfig
      Tint: Color
      FrameLength: int64 }


let bigCharImage =
    { PixelSize = (800, 312)
      Rows = 3
      Columns = 8
      TextureName = "bigChar"
      Offset = Vector2.Zero }

let smallCharImage =
    { PixelSize = (416, 192)
      Rows = 3
      Columns = 8
      TextureName = "smallChar"
      Offset = Vector2(0f, -18f) }

let CharAnimations =
    {| SmallWalk = { Index = 0; Looping = true; Speed = 120; Columns = 8 }
       SmallToBig = { Index = 3; Looping = false; Speed = 80; Columns = 8 }
       BigToSmall = { Index = 4; Looping = false; Speed = 80; Columns = 8 }
       BigWalk = { Index = 5; Looping = true; Speed = 80; Columns = 8 }
       |}

let CharConfig = {| BigSpeed = 80; SmallSpeed = 120 |}

let charSprite =
    { Images = [ smallCharImage; bigCharImage ]
      InitAnimation = CharAnimations.SmallWalk
      Tint = Color.White
      FrameLength = 300L }
