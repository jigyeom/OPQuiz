using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab;
    Queue<GameObject> CubePool = new Queue<GameObject>();
    public static ObjectPool instance = null;

    /// <summary>
    /// 소환할 위치
    /// </summary>
    public Vector3 SpawnPos;

    private int poolSize = 100;


    void Awake()
    {
        if(null == instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            for(int i =0; i < poolSize; ++i)
            {
                CreateCube();
            }
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    GameObject CreateCube()
    {
        GameObject newCube = Instantiate(cubePrefab, SpawnPos, RandomRot());
        newCube.gameObject.SetActive(false);

        return newCube;
    }


    public GameObject GetCube()
    {
        if(CubePool.Count > 0)
        {
            GameObject cubeInPool = CubePool.Dequeue();
            cubeInPool.gameObject.SetActive(true);
            cubeInPool.transform.SetParent(null);

            return cubeInPool;
        }
        else
        {
            GameObject cubeInPool = CreateCube();
            cubeInPool.gameObject.SetActive(true);
            cubeInPool.transform.SetParent(null);

            return cubeInPool;
        }
    }

    public void ReturnCubeToQueue(GameObject cube)
    {
        cube.gameObject.SetActive(false);
        cube.transform.SetParent(instance.transform);
        instance.CubePool.Enqueue(cube);
        
    }

    Quaternion RandomRot()
    {
        float x = Random.Range(0, 360);
        float y = Random.Range(0, 360);
        float z = Random.Range(0, 360);

        Quaternion ret = Quaternion.Euler(x, y, z);
        return ret;
    }

}
