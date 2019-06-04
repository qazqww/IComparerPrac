using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTest : MonoBehaviour
{
    // 접근 지정자 public : 메모리 자동 할당
    public List<Transform> sphereList;

    DistanceComparer distanceComparer = new DistanceComparer();

    void Awake()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("Player");
        distanceComparer.SetTarget(obj.transform);

        sphereList.AddRange(GetComponentsInChildren<Transform>(true));
        sphereList.Sort(distanceComparer);       // Comparer를 사용하는 부분

        for (int i = 0; i < sphereList.Count; i++)
            Debug.Log(sphereList[i].position.magnitude);
    }

    void Update()
    {
        if (sphereList.Count > 0 && distanceComparer != null)
            sphereList.Sort(distanceComparer);
    }
}
