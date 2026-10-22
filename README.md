# Máquina de Rube Goldberg - Unity

Taller 1 (Unity básico y motor de físicas) - Univalle Sede cali.
Autor: Jesus Alberto Tunubala Dagua

## ¿Qué es?
Una reacción en cadena hecha con el motor de físicas de Unity. Consiste en una esfera que cae, detona una fila de fichas de dominó, la última ficha cae en una rampa y rueda hasta una caja Meta que activa una celebración con partículas.

Total: **13 interacciones** (puedes ajustar este número si contaste más o menos).

## Cómo ejecutar
1. Abrir con Unity Hub la carpeta del proyecto (versión 6000.0.85f1 LTS).
2. Abrir la escena ubicada en `Assets/RubeGoldberg/RubeGoldberg.unity`.
3. Presionar Play.

## Conceptos aplicados
- Mesh (visual) vs Collider (físico).
- Rigidbody y gravedad; Collider sin Rigidbody = objeto estático.
- Prefab para las fichas de dominó (con herencia de materiales aplicada).
- Materiales (color, emisión en la esfera) y partículas (confeti).
- Script de cámara (CameraLookAt) para seguir a la esfera.
- Control de versiones con Git + .gitignore de Unity.
