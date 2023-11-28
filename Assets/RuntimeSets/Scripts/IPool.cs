using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPool<T>
{
    void PreWarm(int num);
    T Request();
    void Return(T member);
}
