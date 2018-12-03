﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WishfulDroplet {
	public class MonoState : MonoBehaviour, IState {
		public virtual void OnEnter(IState prevState) { }
		public virtual void OnExit(IState nextState) { }
		public virtual void OnOverride(IState nextState) { }
		public virtual void OnResume(IState prevState) { }
	}
}