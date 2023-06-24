using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ArrowDoDamage : ProjectileDamage
{
    public override IEnumerator ReturnProjectile(float cd)
    {
        yield return new WaitForSeconds(cd);
        ArrowPool.Instance.ReturnToPull(this);
    }

    public override void HitAnimation()
    {
        _hitprefab.Play();
    }
}
