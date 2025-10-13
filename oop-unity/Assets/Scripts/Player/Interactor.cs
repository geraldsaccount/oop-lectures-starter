// Author: Gérald Montúfar
// Created: 28.10.2024

using UnityEngine;
using UnityEngine.InputSystem;

namespace Player {
	public class Interactor : MonoBehaviour {
		[SerializeField] private float _interactRange;
		[SerializeField] private LayerMask _layerMask;

		public void OnInteractInput(InputAction.CallbackContext context) {
			if (!context.performed) return;
			
		}

		private void OnDrawGizmos() {
			Gizmos.DrawWireSphere(transform.position, _interactRange);
		}
	}
}