using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceComparer : IComparer<Transform>
{
    Transform target; // 비교 대상

    public void SetTarget(Transform target)
    {
        this.target = target;
    }

    public int Compare(Transform x, Transform y)
    {
        if (x == null)
        {
            if (y == null) // x와 y가 모두 null일 경우
                return 0;
            else // x만 null일 경우 (y가 큰 것으로 처리)
                return -1;
        }

        else
        {
            if (y == null) // y만 null일 경우 (x가 큰 것으로 처리)
                return 1;
            else // x와 y 모두 값을 가질 경우
            {
                float distX = Vector3.Distance(target.position, x.position);
                float distY = Vector3.Distance(target.position, y.position);
                return distX.CompareTo(distY);

                //if (x.position.magnitude > y.position.magnitude)
                //    return 1;
                //else if (x.position.magnitude < y.position.magnitude)
                //    return -1;
                //else
                //    return 0;
            }
        }
    }    
}
