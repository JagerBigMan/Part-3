using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject daggerPrefab;
    public Transform spawnPoint;

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }
    protected override void Attack()
    {
        destination = transform.position;
        base.Attack();
        Instantiate(daggerPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
