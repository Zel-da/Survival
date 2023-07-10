using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentController : MonoBehaviour
{
    [SerializeField]
    protected GameObject go_effect_prefabs;

    [SerializeField]
    protected float destroyTime;

    protected virtual void PlayStrikeSound(string strikeSound)
    {
        SoundManager.instance.PlaySE(strikeSound);
    }

    protected virtual void PlayDestroySound(string destroySound)
    {
        SoundManager.instance.PlaySE(destroySound);
    }

    protected virtual void SpawnMiningEffect(Vector3 position)
    {
        Instantiate(go_effect_prefabs, position, Quaternion.identity);
    }

    protected virtual void DestroyGameObject(GameObject gameObject)
    {
        Destroy(gameObject);
    }

    protected virtual void DestroyGameObjectDelayed(GameObject gameObject, float delay)
    {
        Destroy(gameObject, delay);
    }
}

