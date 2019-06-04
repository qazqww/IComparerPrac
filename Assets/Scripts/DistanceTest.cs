using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTest : MonoBehaviour
{
    // 접근 지정자 public : 메모리 자동 할당
    public List<Transform> sphereList;

    DistanceCompare distanceCompare = new DistanceCompare();

    private void Start()
    {
        sphereList.AddRange(GetComponentsInChildren<Transform>(true));

        sphereList.Sort(distanceCompare);       // Comparer를 사용하는 부분

        for (int i=0; i<sphereList.Count; i++)
        {
            Debug.Log("");
        }
    }

    private void Update()
    {
        if (sphereList.Count > 0 && distanceCompare != null)
        {
            sphereList.Sort(distanceCompare);
        }
    }
}
