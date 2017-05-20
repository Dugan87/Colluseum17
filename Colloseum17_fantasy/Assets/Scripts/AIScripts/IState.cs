﻿using UnityEngine;
using System.Collections;

public interface IState
{
    void OnEnter();
    void OnUpdate();
    void OnFixedUpdate();
    void OnExit();
}