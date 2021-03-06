﻿using UnityEngine;
using System.Collections;

public class XKTriggerBossUIOpen : MonoBehaviour
{
	[Range(1f, 999f)]public int TimeBoss = 90;
	public AiPathCtrl TestPlayerPath;
	void OnTriggerEnter(Collider other)
	{	
		if (other.GetComponent<XkPlayerCtrl>() == null) {
			return;
		}
		XKBossXueTiaoCtrl.GetInstance().OpenBossXueTiao(TimeBoss);
	}

	void OnDrawGizmosSelected()
	{
		if (!XkGameCtrl.IsDrawGizmosObj) {
			return;
		}
		
		if (!enabled) {
			return;
		}
		
		if (TestPlayerPath != null) {
			TestPlayerPath.DrawPath();
		}
	}
}