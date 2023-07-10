using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enivroment : MonoBehaviour
{
    public string closeEnivromentName; // 오브젝트.

    // 웨폰 유형.
    public bool isRock;
    public bool isTree;

    public float destroyTime; // 파편 제거 시간
    public int hp; // 체력.
    public string strike_Sound; //타격음
    public string destroy_Sound;

    public Animator anim; // 애니메이션.

}
