// Author: Gérald Montúfar
// Created: 28.10.2024

using UnityEngine;
using UnityEngine.InputSystem;

namespace Player {
    public class Movement : MonoBehaviour {
        [SerializeField] private float _maxSpeed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _deceleration;

        private Rigidbody2D _rigidbody;
        private Vector2 _moveInput;
        private Vector2 _dampVelocity;

        private void Awake() {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate() {
            Vector2 desiredVelocity = _moveInput * _maxSpeed;
            if (_rigidbody.linearVelocity.sqrMagnitude > desiredVelocity.sqrMagnitude) {
                _rigidbody.linearVelocity = Vector2.SmoothDamp(_rigidbody.linearVelocity, desiredVelocity, ref _dampVelocity, _deceleration);
            } else if (_rigidbody.linearVelocity.sqrMagnitude < desiredVelocity.sqrMagnitude) {
                _rigidbody.linearVelocity = Vector2.SmoothDamp(_rigidbody.linearVelocity, desiredVelocity, ref _dampVelocity, _acceleration);
            }
        }

        public void OnMoveInput(InputAction.CallbackContext context) {
            _moveInput = context.ReadValue<Vector2>();
        }
    }
}
