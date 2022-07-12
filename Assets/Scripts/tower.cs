using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tower : MonoBehaviour
{
    public Animator anime;
    public float Range;  //골렘 공격범위
    public GameObject Target;
    public GameObject splash;  // 범위 공격
    public GameObject Effect_obj;
    public GameObject Effect_pos;
    public int Damage;
    public Transform PartToRotate;


    void Start()
    {
        anime = GetComponent<Animator>();
        //InvokeRepeating("UpdateTarget", 0f, 0.2f); //바로 시작이므로 0초& 2초주기(초당 5번)
        //OnDrawGizmosSeleted();

    }

    //범위 보여주는 함수
    private void OnDrawGizmosSeleted()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.gameObject.transform.position, Range);
    }
    private void Update()
    {
        UpdateTarget();
        transform.LookAt(Target.transform);  //타겟 바라봄
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        LookAtTarget();
    }

    void UpdateTarget()  //타워가 적을 지속적으로 처리하는거 업뎃
    {
        if (Target == null)  //타겟이 없을때 아래실행
        {
            GameObject[] Monsters = GameObject.FindGameObjectsWithTag("Monster");  //몬스터 태그갖고있는거 저장 
            float shortestDistance = Mathf.Infinity;  //가장 짧음
            GameObject nearestMoster = null;
            foreach (GameObject Monster in Monsters)
            {
                //골렘과 적과의 거리
                float DistanceToMonsters = Vector3.Distance(transform.position, Monster.transform.position);

                if (DistanceToMonsters < shortestDistance)
                {
                    shortestDistance = DistanceToMonsters;
                    nearestMoster = Monster;
                }
            }
            if (nearestMoster != null && shortestDistance <= Range)
            {
                Target = nearestMoster;

                attack();
            }
            else
            {
                idle();
                Target = null;
            }
        }
        //공격하는 거리를 벗어났을 경우 공격 멈춤
        else if(Target != null)
        {
            float DistanceToMonsters = Vector3.Distance(transform.position, Target.transform.position);
            if(DistanceToMonsters > Range)
            {
                idle();
                Target = null;
            }
        }
    }

    public void attack()
    {

        anime.SetInteger("Toweranistate", 2);  //애니메이터 이름(화살표 누르고 Equlse 2 선택) 
       //Target.GetComponent<Mob>().GetDamage(50);
    }

    public void idle()
    {
        anime.SetInteger("Toweranistate", 1);  //애니메이터 이름(화살표 누르고 Equlse 1 선택) 
    }

    
    //골렘에서 때리는거 이펙트. 다만 주먹질하는것이기 때문에 골렘이 주가 되어 적 하나만 때림
    public void splashDamage()
    {
        GameObject flash = Instantiate(splash, new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z + 2f), Quaternion.identity);
        Destroy(flash, 2f);
        Target.GetComponent<Mob>().GetDamage(Damage);
    }

    //군인 타워에서 사용하는 함수(이펙트). 하나만 때림
    public void AttackTarget()
    {
        if(Target !=null)
        {
            GameObject effect = Instantiate(Effect_obj, Effect_pos.transform.position, Quaternion.identity);
            Destroy(effect, 2f);
            Target.GetComponent<Mob>().GetDamage(Damage);
        }
       
    }

    void LookAtTarget()
    {
        if (Target == null)
            return;
        Vector3 dir = Target.transform.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = lookRotation.eulerAngles;
        PartToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);
    }


    
    

}
