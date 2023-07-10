using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : EnvironmentController
{
    [SerializeField]
    private int hp;

    [SerializeField]
    private CapsuleCollider col;

    // Required game objects.
    [SerializeField]
    private GameObject go_tree; // Intact tree.
    [SerializeField]
    private GameObject go_fallenTree; // Fallen tree.

    // Name of the required sounds.
    [SerializeField]
    private string chopSound; // Chop sound.
    [SerializeField]
    private string fallSound; // Fall sound.

    public void ChopTree()
    {
        PlayChopSound();

        var clone = Instantiate(go_effect_prefabs, col.bounds.center, Quaternion.identity);
        DestroyGameObjectDelayed(clone, destroyTime);

        hp--;

        if (hp <= 0)
            FallTree();
    }

    private void FallTree()
    {
        PlayFallSound();

        col.enabled = false;
        DestroyGameObject(go_tree);

        go_fallenTree.SetActive(true);
        DestroyGameObjectDelayed(go_fallenTree, destroyTime);
    }

    protected virtual void PlayChopSound()
    {
        SoundManager.instance.PlaySE(chopSound);
    }

    protected virtual void PlayFallSound()
    {
        SoundManager.instance.PlaySE(fallSound);
    }
}