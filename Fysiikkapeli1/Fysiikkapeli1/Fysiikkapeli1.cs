using System;
using System.Collections.Generic;
using Jypeli;
using Jypeli.Assets;
using Jypeli.Controls;
using Jypeli.Widgets;

namespace Fysiikkapeli1;

public class Fysiikkapeli1 : PhysicsGame
{
    private PhysicsObject pallo;
    
    public override void Begin()
    {

        LuoKentta();
        Vector impulssi = new Vector(500.0, 0.0);
        pallo.Hit(impulssi);
        
        // Kirjoita ohjelmakoodisi tähän

        PhoneBackButton.Listen(ConfirmExit, "Lopeta peli");
        Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");
    }


    void LuoKentta()
    {
         pallo = new PhysicsObject(40.0, 40.0);
        Add(pallo);
        pallo.Shape = Shape.Circle;
        Level.CreateBorders(1.0, false);
        pallo.Restitution = 1.0;
        Level.Background.Color = Color.Black;
        Camera.ZoomToLevel();
    }
}
