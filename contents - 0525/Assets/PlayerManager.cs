using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;

public class PlayerManager : MonoBehaviour
{
    PhotonView PV;

    GameObject controller;

    void Awake()
    {
        PV = GetComponent<PhotonView>();
    }

    void Start()
    {
        if (PV.IsMine)
        {
            CreateController();
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateController()
    {
        //Transform spawnpoint = SpawnManager.Instance.GetSpawnpoint();

          PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PlayerController"), Vector3.zero, Quaternion.identity);

        Debug.Log("Instantiated Player Controller");
    }
}
