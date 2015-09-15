using UnityEngine;
using System.Collections;

public class SlowPlayer : Coin {
    public override void PlayerHit(Player _GO)
    {
        base.PlayerHit(_GO);

        _GO.MoveSpeed = 1;
    }
}
