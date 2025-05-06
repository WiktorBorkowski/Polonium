﻿using UnityEngine;
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
		if(PV.IsMine)
		{
			CreateController();
		}
	}

	void CreateController()
	{
		Transform spawnpoint = SpawnManager.Instance.GetSpawnpoint();
		controller = PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PlayerController"), spawnpoint.position, spawnpoint.rotation, 0, new object[] { PV.ViewID });
	}

	public void Die()
	{
		PhotonNetwork.Destroy(controller);
		CreateController();
	}

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
			Cursor.lockState = CursorLockMode.None;
		}
        else
        {
			Cursor.lockState = CursorLockMode.Locked;
		}
	}
}