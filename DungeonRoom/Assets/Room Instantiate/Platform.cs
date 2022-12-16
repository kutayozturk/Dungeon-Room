using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    List<Transform> odalar = new List<Transform>();
    [SerializeField] private GameObject sopaBoss;
    [SerializeField] private GameObject sopaBonus;
    [SerializeField] private GameObject sopaBonusKoridor;
    [SerializeField] private GameObject bossRoom;
    [SerializeField] private GameObject bonusRoom;
    [SerializeField] private GameObject room;
    [SerializeField] private int bossNumber;
    [SerializeField] private int bonusNumber;

    // Start is called before the first frame update
    void Start()
    {
        odaLateUpdate();
        RandomNumber();
        RandomRoom();

        BossKoridor(sopaBoss);
        BonusKoridor(sopaBonusKoridor);

    }

    private void odaLateUpdate()
    {
        GameObject gObj = GameObject.FindGameObjectWithTag("Odalar");
        foreach (Transform t in gObj.transform)
        {
            odalar.Add(t);
            print(t.name);
        }
    }
    private void RandomRoom()
    {
        bossRoom = odalar[bossNumber].gameObject;
        bonusRoom= odalar[bonusNumber].gameObject;
        Vector3 sopaPos=new Vector3(bossRoom.transform.position.x+5f, bossRoom.transform.position.y, bossRoom.transform.position.z-6f);

        sopaBonusKoridor = Instantiate(sopaBonus, sopaPos, Quaternion.identity);
       // sopaBonusKoridor = Instantiate(sopaBonus,bossRoom.transform.position,Quaternion.identity);

        
        
    }
    private void BossKoridor(GameObject go)
    {
        go.transform.LookAt(bossRoom.transform.position);
    }
    private void BonusKoridor(GameObject go)
    {
        
        go.transform.LookAt(bonusRoom.transform.position);
    }

    private void RandomNumber()
    {
        bossNumber =Random.Range(0, odalar.Count);
        bonusNumber=Random.Range(0, odalar.Count);
        if (bossNumber ==bonusNumber)
        {
            RandomNumber();
        }
    }
}
