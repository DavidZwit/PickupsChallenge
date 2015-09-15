using UnityEngine;
using System.Collections;

public class RotatePlayer : Coin {
    public override void PlayerHit(Player _GO)
    {
        base.PlayerHit(_GO);

        _GO.Rotatation = true;
    }
}
