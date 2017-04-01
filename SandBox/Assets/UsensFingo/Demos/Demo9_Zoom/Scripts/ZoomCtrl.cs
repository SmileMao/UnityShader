﻿/*************************************************************************\
*                           USENS CONFIDENTIAL                            *
* _______________________________________________________________________ *
*                                                                         *
* [2014] - [2017] USENS Incorporated                                      *
* All Rights Reserved.                                                    *
*                                                                         *
* NOTICE:  All information contained herein is, and remains               *
* the property of uSens Incorporated and its suppliers,                   *
* if any.  The intellectual and technical concepts contained              *
* herein are proprietary to uSens Incorporated                            *
* and its suppliers and may be covered by U.S. and Foreign Patents,       *
* patents in process, and are protected by trade secret or copyright law. *
* Dissemination of this information or reproduction of this material      *
* is strictly forbidden unless prior written permission is obtained       *
* from uSens Incorporated.                                                *
*                                                                         *
\*************************************************************************/

using UnityEngine;
using System.Collections;

public class ZoomCtrl : MonoBehaviour
{
    void OnEnable()
    {
        ZoomManager.ZoomEvent += Move;
        ZoomManager.EnterZoomEvent += ChangeColorYellow;
        ZoomManager.QuitZoomEvent += ChangeColorCyan;
    }

    void OnDisable()
    {
        ZoomManager.ZoomEvent -= Move;
        ZoomManager.EnterZoomEvent -= ChangeColorYellow;
        ZoomManager.QuitZoomEvent -= ChangeColorCyan;
    }

    void Move(float displacement)
    {
        this.transform.Translate(new Vector3(0f, 0f, -displacement));
    }

    void ChangeColorYellow()
    {
        GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
    }

    void ChangeColorCyan()
    {
        GetComponent<Renderer>().material.SetColor("_Color", Color.cyan);
    }
}