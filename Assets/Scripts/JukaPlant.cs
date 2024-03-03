using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JukaPlant : BasePlant
{
    public override IEnumerator StartAbility()
    {
        while (true)
        {
            if (isCorruption)
            {
                health -= damagePreSecond;
            }
            if (health <= 0)
                Destroy(gameObject);
            moneyTimer++;

            if (moneyTimer >= moneyDuration)
            {
                // destroy an animy
                moneyTimer = 0;
            }

            yield return new WaitForSeconds(1);
        }
    }
}
