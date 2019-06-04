using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCompare : IComparer<Transform>
{
    public int Compare(Transform x, Transform y)
    {
        if (x == null)
        {
            if (y == null) // x와 y가 모두 null일 경우
                return 0;
            else // x만 null일 경우 (y가 큰 것으로 처리)
                return 1;
        }

        else
        {
            if (y = null) // y만 null일 경우 (x가 큰 것으로 처리)
                return -1;
            else // x와 y 모두 값을 가질 경우
            {
                if (x.position.magnitude > y.position.magnitude)
                    return -1;
                else if (x.position.magnitude < y.position.magnitude)
                    return 1;
            }
        }
        return 0;
    }
}
