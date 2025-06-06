class <Module>
{
}

namespace UnityEngine
{
    struct PhysicsScene2D : System.IEquatable<UnityEngine.PhysicsScene2D>
    {
        /*0x10*/ int m_Handle;

        static /*0x290ff48*/ bool op_Equality(UnityEngine.PhysicsScene2D lhs, UnityEngine.PhysicsScene2D rhs);
        static /*0x290ff54*/ bool op_Inequality(UnityEngine.PhysicsScene2D lhs, UnityEngine.PhysicsScene2D rhs);
        static /*0x2910038*/ bool IsValid_Internal(UnityEngine.PhysicsScene2D physicsScene);
        static /*0x291018c*/ bool IsEmpty_Internal(UnityEngine.PhysicsScene2D physicsScene);
        static /*0x2910550*/ UnityEngine.RaycastHit2D Linecast_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter);
        static /*0x2910730*/ int LinecastArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x2910864*/ int LinecastNonAllocList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        static /*0x2910a00*/ UnityEngine.RaycastHit2D Raycast_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        static /*0x2910c10*/ int RaycastArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x2910d64*/ int RaycastList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        static /*0x2910f28*/ UnityEngine.RaycastHit2D CircleCast_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        static /*0x2911150*/ int CircleCastArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x29112b4*/ int CircleCastList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        static /*0x29114a0*/ UnityEngine.RaycastHit2D BoxCast_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        static /*0x29116f0*/ int BoxCastArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x2911864*/ int BoxCastList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        static /*0x2911a68*/ UnityEngine.RaycastHit2D CapsuleCast_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        static /*0x2911ce0*/ int CapsuleCastArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x2911e74*/ int CapsuleCastList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        static /*0x291205c*/ UnityEngine.RaycastHit2D GetRayIntersection_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask);
        static /*0x2912200*/ int GetRayIntersectionArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask, UnityEngine.RaycastHit2D[] results);
        static /*0x29122fc*/ int GetRayIntersectionList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        static /*0x291246c*/ UnityEngine.Collider2D OverlapPoint_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.ContactFilter2D contactFilter);
        static /*0x29125cc*/ int OverlapPointArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x29126e8*/ int OverlapPointList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        static /*0x2912828*/ UnityEngine.Collider2D OverlapCircle_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, float radius, UnityEngine.ContactFilter2D contactFilter);
        static /*0x29129b8*/ int OverlapCircleArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, float radius, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x2912af4*/ int OverlapCircleList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, float radius, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        static /*0x2912c6c*/ UnityEngine.Collider2D OverlapBox_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.ContactFilter2D contactFilter);
        static /*0x2912e24*/ int OverlapBoxArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x2912f78*/ int OverlapBoxList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        static /*0x2913580*/ UnityEngine.Collider2D OverlapCapsule_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.ContactFilter2D contactFilter);
        static /*0x2913758*/ int OverlapCapsuleArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x29138c4*/ int OverlapCapsuleList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        static /*0x29139d0*/ int OverlapCollider(UnityEngine.Collider2D collider, UnityEngine.Collider2D[] results, int layerMask);
        static /*0x2913ab0*/ int OverlapCollider(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x2913a5c*/ int OverlapColliderArray_Internal(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x2913b68*/ int OverlapCollider(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        static /*0x2913bcc*/ int OverlapColliderList_Internal(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        static /*0x291007c*/ bool IsValid_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene);
        static /*0x29101d0*/ bool IsEmpty_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene);
        static /*0x2910628*/ void Linecast_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 start, ref UnityEngine.Vector2 end, ref UnityEngine.ContactFilter2D contactFilter, ref UnityEngine.RaycastHit2D ret);
        static /*0x29107c8*/ int LinecastArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 start, ref UnityEngine.Vector2 end, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x29108cc*/ int LinecastNonAllocList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 start, ref UnityEngine.Vector2 end, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        static /*0x2910ae8*/ void Raycast_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, ref UnityEngine.RaycastHit2D ret);
        static /*0x2910cb8*/ int RaycastArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x2910ddc*/ int RaycastList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        static /*0x2911018*/ void CircleCast_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, float radius, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, ref UnityEngine.RaycastHit2D ret);
        static /*0x2911200*/ int CircleCastArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, float radius, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x2911334*/ int CircleCastList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, float radius, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        static /*0x2911598*/ void BoxCast_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 size, float angle, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, ref UnityEngine.RaycastHit2D ret);
        static /*0x29117a8*/ int BoxCastArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 size, float angle, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x29118ec*/ int BoxCastList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 size, float angle, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        static /*0x2911b70*/ void CapsuleCast_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, ref UnityEngine.RaycastHit2D ret);
        static /*0x2911da8*/ int CapsuleCastArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x2911f0c*/ int CapsuleCastList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        static /*0x29120f8*/ void GetRayIntersection_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 direction, float distance, int layerMask, ref UnityEngine.RaycastHit2D ret);
        static /*0x2912280*/ int GetRayIntersectionArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 direction, float distance, int layerMask, UnityEngine.RaycastHit2D[] results);
        static /*0x291237c*/ int GetRayIntersectionList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 direction, float distance, int layerMask, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        static /*0x29124f4*/ UnityEngine.Collider2D OverlapPoint_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.ContactFilter2D contactFilter);
        static /*0x291265c*/ int OverlapPointArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x2912748*/ int OverlapPointList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        static /*0x29128c0*/ UnityEngine.Collider2D OverlapCircle_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, float radius, ref UnityEngine.ContactFilter2D contactFilter);
        static /*0x2912a58*/ int OverlapCircleArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, float radius, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x2912b64*/ int OverlapCircleList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, float radius, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        static /*0x2912d0c*/ UnityEngine.Collider2D OverlapBox_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.Vector2 size, float angle, ref UnityEngine.ContactFilter2D contactFilter);
        static /*0x2912ecc*/ int OverlapBoxArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.Vector2 size, float angle, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x2912ff0*/ int OverlapBoxList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.Vector2 size, float angle, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        static /*0x2913628*/ UnityEngine.Collider2D OverlapCapsule_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, ref UnityEngine.ContactFilter2D contactFilter);
        static /*0x2913810*/ int OverlapCapsuleArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x291394c*/ int OverlapCapsuleList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        static /*0x2913b14*/ int OverlapColliderArray_Internal_Injected(UnityEngine.Collider2D collider, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x2913c20*/ int OverlapColliderList_Internal_Injected(UnityEngine.Collider2D collider, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        /*0x290fe64*/ string ToString();
        /*0x290ff60*/ int GetHashCode();
        /*0x290ff68*/ bool Equals(object other);
        /*0x290ffe0*/ bool Equals(UnityEngine.PhysicsScene2D other);
        /*0x290fff0*/ bool IsValid();
        /*0x29100b8*/ bool IsEmpty();
        /*0x291020c*/ bool Simulate(float step);
        /*0x2910398*/ UnityEngine.RaycastHit2D Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, int layerMask);
        /*0x29105d4*/ UnityEngine.RaycastHit2D Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter);
        /*0x2910694*/ int Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.RaycastHit2D[] results, int layerMask);
        /*0x2910798*/ int Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        /*0x2910834*/ int Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        /*0x2910938*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask);
        /*0x2910a94*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        /*0x2910b64*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.RaycastHit2D[] results, int layerMask);
        /*0x2910c88*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        /*0x2910d34*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        /*0x2910e58*/ UnityEngine.RaycastHit2D CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, int layerMask);
        /*0x2910fc4*/ UnityEngine.RaycastHit2D CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        /*0x291109c*/ int CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, UnityEngine.RaycastHit2D[] results, int layerMask);
        /*0x29111d0*/ int CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        /*0x2911284*/ int CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        /*0x29113b8*/ UnityEngine.RaycastHit2D BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, int layerMask);
        /*0x2911544*/ UnityEngine.RaycastHit2D BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        /*0x2911624*/ int BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.RaycastHit2D[] results, int layerMask);
        /*0x2911778*/ int BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        /*0x2911834*/ int BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        /*0x2911978*/ UnityEngine.RaycastHit2D CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, int layerMask);
        /*0x2911b1c*/ UnityEngine.RaycastHit2D CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        /*0x2911c0c*/ int CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.RaycastHit2D[] results, int layerMask);
        /*0x2911d78*/ int CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        /*0x2911e44*/ int CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        /*0x2911fa8*/ UnityEngine.RaycastHit2D GetRayIntersection(UnityEngine.Ray ray, float distance, int layerMask);
        /*0x2912174*/ int GetRayIntersection(UnityEngine.Ray ray, float distance, UnityEngine.RaycastHit2D[] results, int layerMask);
        /*0x29123f8*/ UnityEngine.Collider2D OverlapPoint(UnityEngine.Vector2 point, int layerMask);
        /*0x29124c4*/ UnityEngine.Collider2D OverlapPoint(UnityEngine.Vector2 point, UnityEngine.ContactFilter2D contactFilter);
        /*0x2912548*/ int OverlapPoint(UnityEngine.Vector2 point, UnityEngine.Collider2D[] results, int layerMask);
        /*0x291262c*/ int OverlapPoint(UnityEngine.Vector2 point, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        /*0x29126b8*/ int OverlapPoint(UnityEngine.Vector2 point, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        /*0x29127a4*/ UnityEngine.Collider2D OverlapCircle(UnityEngine.Vector2 point, float radius, int layerMask);
        /*0x2912890*/ UnityEngine.Collider2D OverlapCircle(UnityEngine.Vector2 point, float radius, UnityEngine.ContactFilter2D contactFilter);
        /*0x2912924*/ int OverlapCircle(UnityEngine.Vector2 point, float radius, UnityEngine.Collider2D[] results, int layerMask);
        /*0x2912a28*/ int OverlapCircle(UnityEngine.Vector2 point, float radius, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        /*0x2912ac4*/ int OverlapCircle(UnityEngine.Vector2 point, float radius, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        /*0x2912bd0*/ UnityEngine.Collider2D OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, int layerMask);
        /*0x2912cdc*/ UnityEngine.Collider2D OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.ContactFilter2D contactFilter);
        /*0x2912d78*/ int OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.Collider2D[] results, int layerMask);
        /*0x2912e9c*/ int OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        /*0x2912f48*/ int OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        /*0x291306c*/ UnityEngine.Collider2D OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, int layerMask);
        /*0x29131dc*/ UnityEngine.Collider2D OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.ContactFilter2D contactFilter);
        /*0x29130f8*/ UnityEngine.Collider2D OverlapAreaToBoxArray_Internal(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.ContactFilter2D contactFilter);
        /*0x2913208*/ int OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.Collider2D[] results, int layerMask);
        /*0x2913390*/ int OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        /*0x29132a4*/ int OverlapAreaToBoxArray_Internal(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        /*0x29133bc*/ int OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        /*0x29133e8*/ int OverlapAreaToBoxList_Internal(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        /*0x29134d4*/ UnityEngine.Collider2D OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, int layerMask);
        /*0x29135f8*/ UnityEngine.Collider2D OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.ContactFilter2D contactFilter);
        /*0x29136a4*/ int OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.Collider2D[] results, int layerMask);
        /*0x29137e0*/ int OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        /*0x2913894*/ int OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
    }

    class PhysicsSceneExtensions2D
    {
        static /*0x2913c74*/ UnityEngine.PhysicsScene2D GetPhysicsScene2D(UnityEngine.SceneManagement.Scene scene);
        static /*0x2913d7c*/ UnityEngine.PhysicsScene2D GetPhysicsScene_Internal(UnityEngine.SceneManagement.Scene scene);
        static /*0x2913dc8*/ void GetPhysicsScene_Internal_Injected(ref UnityEngine.SceneManagement.Scene scene, ref UnityEngine.PhysicsScene2D ret);
    }

    class Physics2D
    {
        static int IgnoreRaycastLayer = 4;
        static int DefaultRaycastLayers = -5;
        static int AllLayers = -1;
        static int MaxPolygonShapeVertices = 8;
        static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rigidbody2D> m_LastDisabledRigidbody2D;

        static /*0x2921390*/ Physics2D();
        static /*0x2913e0c*/ UnityEngine.PhysicsScene2D get_defaultPhysicsScene();
        static /*0x2913e14*/ int get_velocityIterations();
        static /*0x2913e3c*/ void set_velocityIterations(int value);
        static /*0x2913e78*/ int get_positionIterations();
        static /*0x2913ea0*/ void set_positionIterations(int value);
        static /*0x2913edc*/ UnityEngine.Vector2 get_gravity();
        static /*0x2913f94*/ void set_gravity(UnityEngine.Vector2 value);
        static /*0x2914048*/ bool get_queriesHitTriggers();
        static /*0x2914070*/ void set_queriesHitTriggers(bool value);
        static /*0x29140ac*/ bool get_queriesStartInColliders();
        static /*0x29140d4*/ void set_queriesStartInColliders(bool value);
        static /*0x2914110*/ bool get_callbacksOnDisable();
        static /*0x2914138*/ void set_callbacksOnDisable(bool value);
        static /*0x2914174*/ bool get_reuseCollisionCallbacks();
        static /*0x291419c*/ void set_reuseCollisionCallbacks(bool value);
        static /*0x29141d8*/ bool get_autoSyncTransforms();
        static /*0x2914200*/ void set_autoSyncTransforms(bool value);
        static /*0x291423c*/ UnityEngine.SimulationMode2D get_simulationMode();
        static /*0x2914264*/ void set_simulationMode(UnityEngine.SimulationMode2D value);
        static /*0x29142a0*/ UnityEngine.PhysicsJobOptions2D get_jobOptions();
        static /*0x2914378*/ void set_jobOptions(UnityEngine.PhysicsJobOptions2D value);
        static /*0x2914428*/ float get_velocityThreshold();
        static /*0x2914450*/ void set_velocityThreshold(float value);
        static /*0x2914488*/ float get_maxLinearCorrection();
        static /*0x29144b0*/ void set_maxLinearCorrection(float value);
        static /*0x29144e8*/ float get_maxAngularCorrection();
        static /*0x2914510*/ void set_maxAngularCorrection(float value);
        static /*0x2914548*/ float get_maxTranslationSpeed();
        static /*0x2914570*/ void set_maxTranslationSpeed(float value);
        static /*0x29145a8*/ float get_maxRotationSpeed();
        static /*0x29145d0*/ void set_maxRotationSpeed(float value);
        static /*0x2914608*/ float get_defaultContactOffset();
        static /*0x2914630*/ void set_defaultContactOffset(float value);
        static /*0x2914668*/ float get_baumgarteScale();
        static /*0x2914690*/ void set_baumgarteScale(float value);
        static /*0x29146c8*/ float get_baumgarteTOIScale();
        static /*0x29146f0*/ void set_baumgarteTOIScale(float value);
        static /*0x2914728*/ float get_timeToSleep();
        static /*0x2914750*/ void set_timeToSleep(float value);
        static /*0x2914788*/ float get_linearSleepTolerance();
        static /*0x29147b0*/ void set_linearSleepTolerance(float value);
        static /*0x29147e8*/ float get_angularSleepTolerance();
        static /*0x2914810*/ void set_angularSleepTolerance(float value);
        static /*0x2914848*/ bool get_alwaysShowColliders();
        static /*0x2914870*/ void set_alwaysShowColliders(bool value);
        static /*0x29148ac*/ bool get_showColliderSleep();
        static /*0x29148d4*/ void set_showColliderSleep(bool value);
        static /*0x2914910*/ bool get_showColliderContacts();
        static /*0x2914938*/ void set_showColliderContacts(bool value);
        static /*0x2914974*/ bool get_showColliderAABB();
        static /*0x291499c*/ void set_showColliderAABB(bool value);
        static /*0x29149d8*/ float get_contactArrowScale();
        static /*0x2914a00*/ void set_contactArrowScale(float value);
        static /*0x2914a38*/ UnityEngine.Color get_colliderAwakeColor();
        static /*0x2914afc*/ void set_colliderAwakeColor(UnityEngine.Color value);
        static /*0x2914bbc*/ UnityEngine.Color get_colliderAsleepColor();
        static /*0x2914c80*/ void set_colliderAsleepColor(UnityEngine.Color value);
        static /*0x2914d40*/ UnityEngine.Color get_colliderContactColor();
        static /*0x2914e04*/ void set_colliderContactColor(UnityEngine.Color value);
        static /*0x2914ec4*/ UnityEngine.Color get_colliderAABBColor();
        static /*0x2914f88*/ void set_colliderAABBColor(UnityEngine.Color value);
        static /*0x2915048*/ bool Simulate(float step);
        static /*0x2910304*/ bool Simulate_Internal(UnityEngine.PhysicsScene2D physicsScene, float step);
        static /*0x29150f4*/ void SyncTransforms();
        static /*0x291511c*/ void IgnoreCollision(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2);
        static /*0x29151a4*/ void IgnoreCollision(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, bool ignore);
        static /*0x29151f8*/ bool GetIgnoreCollision(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2);
        static /*0x291523c*/ void IgnoreLayerCollision(int layer1, int layer2);
        static /*0x29152a4*/ void IgnoreLayerCollision(int layer1, int layer2, bool ignore);
        static /*0x29153b0*/ void IgnoreLayerCollision_Internal(int layer1, int layer2, bool ignore);
        static /*0x2915404*/ bool GetIgnoreLayerCollision(int layer1, int layer2);
        static /*0x2915500*/ bool GetIgnoreLayerCollision_Internal(int layer1, int layer2);
        static /*0x2915544*/ void SetLayerCollisionMask(int layer, int layerMask);
        static /*0x2915614*/ void SetLayerCollisionMask_Internal(int layer, int layerMask);
        static /*0x2915658*/ int GetLayerCollisionMask(int layer);
        static /*0x2915720*/ int GetLayerCollisionMask_Internal(int layer);
        static /*0x291575c*/ bool IsTouching(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2);
        static /*0x29157a0*/ bool IsTouching(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, UnityEngine.ContactFilter2D contactFilter);
        static /*0x291583c*/ bool IsTouching_TwoCollidersWithFilter(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, UnityEngine.ContactFilter2D contactFilter);
        static /*0x291591c*/ bool IsTouching(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter);
        static /*0x29159b0*/ bool IsTouching_SingleColliderWithFilter(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter);
        static /*0x2915a78*/ bool IsTouchingLayers(UnityEngine.Collider2D collider);
        static /*0x2915af0*/ bool IsTouchingLayers(UnityEngine.Collider2D collider, int layerMask);
        static /*0x2915b34*/ UnityEngine.ColliderDistance2D Distance(UnityEngine.Collider2D colliderA, UnityEngine.Collider2D colliderB);
        static /*0x2915ce4*/ UnityEngine.ColliderDistance2D Distance_Internal(UnityEngine.Collider2D colliderA, UnityEngine.Collider2D colliderB);
        static /*0x2915de0*/ UnityEngine.Vector2 ClosestPoint(UnityEngine.Vector2 position, UnityEngine.Collider2D collider);
        static /*0x2915f64*/ UnityEngine.Vector2 ClosestPoint(UnityEngine.Vector2 position, UnityEngine.Rigidbody2D rigidbody);
        static /*0x2915ed0*/ UnityEngine.Vector2 ClosestPoint_Collider(UnityEngine.Vector2 position, UnityEngine.Collider2D collider);
        static /*0x2916054*/ UnityEngine.Vector2 ClosestPoint_Rigidbody(UnityEngine.Vector2 position, UnityEngine.Rigidbody2D rigidbody);
        static /*0x2916190*/ UnityEngine.RaycastHit2D Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end);
        static /*0x291624c*/ UnityEngine.RaycastHit2D Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, int layerMask);
        static /*0x2916358*/ UnityEngine.RaycastHit2D Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, int layerMask, float minDepth);
        static /*0x291646c*/ UnityEngine.RaycastHit2D Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, int layerMask, float minDepth, float maxDepth);
        static /*0x2916580*/ int Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x2916634*/ int Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        static /*0x29166e8*/ UnityEngine.RaycastHit2D[] LinecastAll(UnityEngine.Vector2 start, UnityEngine.Vector2 end);
        static /*0x2916848*/ UnityEngine.RaycastHit2D[] LinecastAll(UnityEngine.Vector2 start, UnityEngine.Vector2 end, int layerMask);
        static /*0x2916914*/ UnityEngine.RaycastHit2D[] LinecastAll(UnityEngine.Vector2 start, UnityEngine.Vector2 end, int layerMask, float minDepth);
        static /*0x29169e8*/ UnityEngine.RaycastHit2D[] LinecastAll(UnityEngine.Vector2 start, UnityEngine.Vector2 end, int layerMask, float minDepth, float maxDepth);
        static /*0x29167b0*/ UnityEngine.RaycastHit2D[] LinecastAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter);
        static /*0x2916b18*/ int LinecastNonAlloc(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.RaycastHit2D[] results);
        static /*0x2916bb8*/ int LinecastNonAlloc(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.RaycastHit2D[] results, int layerMask);
        static /*0x2916c94*/ int LinecastNonAlloc(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.RaycastHit2D[] results, int layerMask, float minDepth);
        static /*0x2916d78*/ int LinecastNonAlloc(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.RaycastHit2D[] results, int layerMask, float minDepth, float maxDepth);
        static /*0x2916e5c*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction);
        static /*0x2916f20*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance);
        static /*0x2916fec*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask);
        static /*0x2917108*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth);
        static /*0x2917224*/ UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
        static /*0x2917348*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x2917404*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance);
        static /*0x29174c8*/ int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance);
        static /*0x291758c*/ int RaycastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results);
        static /*0x2917634*/ int RaycastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance);
        static /*0x29176dc*/ int RaycastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask);
        static /*0x29177c8*/ int RaycastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask, float minDepth);
        static /*0x29178b4*/ int RaycastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask, float minDepth, float maxDepth);
        static /*0x29179a8*/ UnityEngine.RaycastHit2D[] RaycastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction);
        static /*0x2917b20*/ UnityEngine.RaycastHit2D[] RaycastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance);
        static /*0x2917bf8*/ UnityEngine.RaycastHit2D[] RaycastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask);
        static /*0x2917cd4*/ UnityEngine.RaycastHit2D[] RaycastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth);
        static /*0x2917db0*/ UnityEngine.RaycastHit2D[] RaycastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
        static /*0x2917a78*/ UnityEngine.RaycastHit2D[] RaycastAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        static /*0x2917f00*/ UnityEngine.RaycastHit2D CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction);
        static /*0x2917fd4*/ UnityEngine.RaycastHit2D CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance);
        static /*0x29180a8*/ UnityEngine.RaycastHit2D CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, int layerMask);
        static /*0x29181cc*/ UnityEngine.RaycastHit2D CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth);
        static /*0x29182f8*/ UnityEngine.RaycastHit2D CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
        static /*0x2918424*/ int CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x29184f0*/ int CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance);
        static /*0x29185bc*/ int CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance);
        static /*0x2918688*/ UnityEngine.RaycastHit2D[] CircleCastAll(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction);
        static /*0x2918818*/ UnityEngine.RaycastHit2D[] CircleCastAll(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance);
        static /*0x29188f8*/ UnityEngine.RaycastHit2D[] CircleCastAll(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, int layerMask);
        static /*0x29189dc*/ UnityEngine.RaycastHit2D[] CircleCastAll(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth);
        static /*0x2918ac8*/ UnityEngine.RaycastHit2D[] CircleCastAll(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
        static /*0x2918768*/ UnityEngine.RaycastHit2D[] CircleCastAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        static /*0x2918c28*/ int CircleCastNonAlloc(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results);
        static /*0x2918cd8*/ int CircleCastNonAlloc(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance);
        static /*0x2918d90*/ int CircleCastNonAlloc(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask);
        static /*0x2918e84*/ int CircleCastNonAlloc(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask, float minDepth);
        static /*0x2918f80*/ int CircleCastNonAlloc(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask, float minDepth, float maxDepth);
        static /*0x291907c*/ UnityEngine.RaycastHit2D BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction);
        static /*0x2919168*/ UnityEngine.RaycastHit2D BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance);
        static /*0x2919254*/ UnityEngine.RaycastHit2D BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, int layerMask);
        static /*0x2919390*/ UnityEngine.RaycastHit2D BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth);
        static /*0x29194cc*/ UnityEngine.RaycastHit2D BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
        static /*0x2919600*/ int BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x29196e4*/ int BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance);
        static /*0x29197c8*/ int BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance);
        static /*0x29198ac*/ UnityEngine.RaycastHit2D[] BoxCastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction);
        static /*0x2919a5c*/ UnityEngine.RaycastHit2D[] BoxCastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance);
        static /*0x2919b54*/ UnityEngine.RaycastHit2D[] BoxCastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, int layerMask);
        static /*0x2919c50*/ UnityEngine.RaycastHit2D[] BoxCastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth);
        static /*0x2919d4c*/ UnityEngine.RaycastHit2D[] BoxCastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
        static /*0x29199a4*/ UnityEngine.RaycastHit2D[] BoxCastAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        static /*0x2919ec4*/ int BoxCastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results);
        static /*0x2919f8c*/ int BoxCastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance);
        static /*0x291a05c*/ int BoxCastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask);
        static /*0x291a168*/ int BoxCastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask, float minDepth);
        static /*0x291a274*/ int BoxCastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask, float minDepth, float maxDepth);
        static /*0x291a378*/ UnityEngine.RaycastHit2D CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction);
        static /*0x291a474*/ UnityEngine.RaycastHit2D CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance);
        static /*0x291a570*/ UnityEngine.RaycastHit2D CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, int layerMask);
        static /*0x291a6bc*/ UnityEngine.RaycastHit2D CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth);
        static /*0x291a808*/ UnityEngine.RaycastHit2D CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
        static /*0x291a94c*/ int CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        static /*0x291aa38*/ int CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance);
        static /*0x291ab24*/ int CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance);
        static /*0x291ac10*/ UnityEngine.RaycastHit2D[] CapsuleCastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction);
        static /*0x291add8*/ UnityEngine.RaycastHit2D[] CapsuleCastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance);
        static /*0x291ad10*/ UnityEngine.RaycastHit2D[] CapsuleCastAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter);
        static /*0x291af64*/ UnityEngine.RaycastHit2D[] CapsuleCastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, int layerMask);
        static /*0x291b070*/ UnityEngine.RaycastHit2D[] CapsuleCastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth);
        static /*0x291b17c*/ UnityEngine.RaycastHit2D[] CapsuleCastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);
        static /*0x291b280*/ int CapsuleCastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results);
        static /*0x291b360*/ int CapsuleCastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance);
        static /*0x291b438*/ int CapsuleCastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask);
        static /*0x291b54c*/ int CapsuleCastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask, float minDepth);
        static /*0x291b660*/ int CapsuleCastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask, float minDepth, float maxDepth);
        static /*0x291b76c*/ UnityEngine.RaycastHit2D GetRayIntersection(UnityEngine.Ray ray);
        static /*0x291b820*/ UnityEngine.RaycastHit2D GetRayIntersection(UnityEngine.Ray ray, float distance);
        static /*0x291b8dc*/ UnityEngine.RaycastHit2D GetRayIntersection(UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x291b99c*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray);
        static /*0x291baf8*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray, float distance);
        static /*0x291bba4*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray, float distance, int layerMask);
        static /*0x291ba48*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask);
        static /*0x291bcc8*/ int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results);
        static /*0x291bd60*/ int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results, float distance);
        static /*0x291be00*/ int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results, float distance, int layerMask);
        static /*0x291bea4*/ UnityEngine.Collider2D OverlapPoint(UnityEngine.Vector2 point);
        static /*0x291bf1c*/ UnityEngine.Collider2D OverlapPoint(UnityEngine.Vector2 point, int layerMask);
        static /*0x291bfd0*/ UnityEngine.Collider2D OverlapPoint(UnityEngine.Vector2 point, int layerMask, float minDepth);
        static /*0x291c08c*/ UnityEngine.Collider2D OverlapPoint(UnityEngine.Vector2 point, int layerMask, float minDepth, float maxDepth);
        static /*0x291c148*/ int OverlapPoint(UnityEngine.Vector2 point, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x291c1e4*/ int OverlapPoint(UnityEngine.Vector2 point, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        static /*0x291c280*/ UnityEngine.Collider2D[] OverlapPointAll(UnityEngine.Vector2 point);
        static /*0x291c3c0*/ UnityEngine.Collider2D[] OverlapPointAll(UnityEngine.Vector2 point, int layerMask);
        static /*0x291c474*/ UnityEngine.Collider2D[] OverlapPointAll(UnityEngine.Vector2 point, int layerMask, float minDepth);
        static /*0x291c530*/ UnityEngine.Collider2D[] OverlapPointAll(UnityEngine.Vector2 point, int layerMask, float minDepth, float maxDepth);
        static /*0x291c330*/ UnityEngine.Collider2D[] OverlapPointAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.ContactFilter2D contactFilter);
        static /*0x291c640*/ int OverlapPointNonAlloc(UnityEngine.Vector2 point, UnityEngine.Collider2D[] results);
        static /*0x291c6c8*/ int OverlapPointNonAlloc(UnityEngine.Vector2 point, UnityEngine.Collider2D[] results, int layerMask);
        static /*0x291c78c*/ int OverlapPointNonAlloc(UnityEngine.Vector2 point, UnityEngine.Collider2D[] results, int layerMask, float minDepth);
        static /*0x291c858*/ int OverlapPointNonAlloc(UnityEngine.Vector2 point, UnityEngine.Collider2D[] results, int layerMask, float minDepth, float maxDepth);
        static /*0x291c924*/ UnityEngine.Collider2D OverlapCircle(UnityEngine.Vector2 point, float radius);
        static /*0x291c9b4*/ UnityEngine.Collider2D OverlapCircle(UnityEngine.Vector2 point, float radius, int layerMask);
        static /*0x291ca78*/ UnityEngine.Collider2D OverlapCircle(UnityEngine.Vector2 point, float radius, int layerMask, float minDepth);
        static /*0x291cb3c*/ UnityEngine.Collider2D OverlapCircle(UnityEngine.Vector2 point, float radius, int layerMask, float minDepth, float maxDepth);
        static /*0x291cc08*/ int OverlapCircle(UnityEngine.Vector2 point, float radius, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x291ccb4*/ int OverlapCircle(UnityEngine.Vector2 point, float radius, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        static /*0x291cd60*/ UnityEngine.Collider2D[] OverlapCircleAll(UnityEngine.Vector2 point, float radius);
        static /*0x291cec0*/ UnityEngine.Collider2D[] OverlapCircleAll(UnityEngine.Vector2 point, float radius, int layerMask);
        static /*0x291cf84*/ UnityEngine.Collider2D[] OverlapCircleAll(UnityEngine.Vector2 point, float radius, int layerMask, float minDepth);
        static /*0x291d048*/ UnityEngine.Collider2D[] OverlapCircleAll(UnityEngine.Vector2 point, float radius, int layerMask, float minDepth, float maxDepth);
        static /*0x291ce20*/ UnityEngine.Collider2D[] OverlapCircleAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, float radius, UnityEngine.ContactFilter2D contactFilter);
        static /*0x291d178*/ int OverlapCircleNonAlloc(UnityEngine.Vector2 point, float radius, UnityEngine.Collider2D[] results);
        static /*0x291d208*/ int OverlapCircleNonAlloc(UnityEngine.Vector2 point, float radius, UnityEngine.Collider2D[] results, int layerMask);
        static /*0x291d2dc*/ int OverlapCircleNonAlloc(UnityEngine.Vector2 point, float radius, UnityEngine.Collider2D[] results, int layerMask, float minDepth);
        static /*0x291d3b0*/ int OverlapCircleNonAlloc(UnityEngine.Vector2 point, float radius, UnityEngine.Collider2D[] results, int layerMask, float minDepth, float maxDepth);
        static /*0x291d48c*/ UnityEngine.Collider2D OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle);
        static /*0x291d534*/ UnityEngine.Collider2D OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, int layerMask);
        static /*0x291d610*/ UnityEngine.Collider2D OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, int layerMask, float minDepth);
        static /*0x291d6ec*/ UnityEngine.Collider2D OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, int layerMask, float minDepth, float maxDepth);
        static /*0x291d7d0*/ int OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x291d894*/ int OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        static /*0x291d958*/ UnityEngine.Collider2D[] OverlapBoxAll(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle);
        static /*0x291dad8*/ UnityEngine.Collider2D[] OverlapBoxAll(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, int layerMask);
        static /*0x291dbb4*/ UnityEngine.Collider2D[] OverlapBoxAll(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, int layerMask, float minDepth);
        static /*0x291dc90*/ UnityEngine.Collider2D[] OverlapBoxAll(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, int layerMask, float minDepth, float maxDepth);
        static /*0x291da30*/ UnityEngine.Collider2D[] OverlapBoxAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.ContactFilter2D contactFilter);
        static /*0x291dde0*/ int OverlapBoxNonAlloc(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.Collider2D[] results);
        static /*0x291de88*/ int OverlapBoxNonAlloc(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.Collider2D[] results, int layerMask);
        static /*0x291df74*/ int OverlapBoxNonAlloc(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.Collider2D[] results, int layerMask, float minDepth);
        static /*0x291e060*/ int OverlapBoxNonAlloc(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.Collider2D[] results, int layerMask, float minDepth, float maxDepth);
        static /*0x291e154*/ UnityEngine.Collider2D OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB);
        static /*0x291e1e4*/ UnityEngine.Collider2D OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, int layerMask);
        static /*0x291e2b8*/ UnityEngine.Collider2D OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, int layerMask, float minDepth);
        static /*0x291e394*/ UnityEngine.Collider2D OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, int layerMask, float minDepth, float maxDepth);
        static /*0x291e470*/ int OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x291e52c*/ int OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        static /*0x291e5e8*/ UnityEngine.Collider2D[] OverlapAreaAll(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB);
        static /*0x291e768*/ UnityEngine.Collider2D[] OverlapAreaAll(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, int layerMask);
        static /*0x291e7fc*/ UnityEngine.Collider2D[] OverlapAreaAll(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, int layerMask, float minDepth);
        static /*0x291e898*/ UnityEngine.Collider2D[] OverlapAreaAll(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, int layerMask, float minDepth, float maxDepth);
        static /*0x291e678*/ UnityEngine.Collider2D[] OverlapAreaAllToBox_Internal(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, int layerMask, float minDepth, float maxDepth);
        static /*0x291e934*/ int OverlapAreaNonAlloc(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.Collider2D[] results);
        static /*0x291e9d4*/ int OverlapAreaNonAlloc(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.Collider2D[] results, int layerMask);
        static /*0x291eab8*/ int OverlapAreaNonAlloc(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.Collider2D[] results, int layerMask, float minDepth);
        static /*0x291eba4*/ int OverlapAreaNonAlloc(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.Collider2D[] results, int layerMask, float minDepth, float maxDepth);
        static /*0x291ec90*/ UnityEngine.Collider2D OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle);
        static /*0x291ed38*/ UnityEngine.Collider2D OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, int layerMask);
        static /*0x291ee24*/ UnityEngine.Collider2D OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, int layerMask, float minDepth);
        static /*0x291ef10*/ UnityEngine.Collider2D OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, int layerMask, float minDepth, float maxDepth);
        static /*0x291f004*/ int OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x291f0d0*/ int OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        static /*0x291f19c*/ UnityEngine.Collider2D[] OverlapCapsuleAll(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle);
        static /*0x291f334*/ UnityEngine.Collider2D[] OverlapCapsuleAll(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, int layerMask);
        static /*0x291f420*/ UnityEngine.Collider2D[] OverlapCapsuleAll(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, int layerMask, float minDepth);
        static /*0x291f50c*/ UnityEngine.Collider2D[] OverlapCapsuleAll(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, int layerMask, float minDepth, float maxDepth);
        static /*0x291f27c*/ UnityEngine.Collider2D[] OverlapCapsuleAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.ContactFilter2D contactFilter);
        static /*0x291f67c*/ int OverlapCapsuleNonAlloc(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.Collider2D[] results);
        static /*0x291f73c*/ int OverlapCapsuleNonAlloc(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.Collider2D[] results, int layerMask);
        static /*0x291f830*/ int OverlapCapsuleNonAlloc(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.Collider2D[] results, int layerMask, float minDepth);
        static /*0x291f924*/ int OverlapCapsuleNonAlloc(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.Collider2D[] results, int layerMask, float minDepth, float maxDepth);
        static /*0x291fa20*/ int OverlapCollider(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x291fa84*/ int OverlapCollider(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        static /*0x291fae8*/ int GetContacts(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] contacts);
        static /*0x291fc2c*/ int GetContacts(UnityEngine.Collider2D collider, UnityEngine.ContactPoint2D[] contacts);
        static /*0x291fdb8*/ int GetContacts(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] contacts);
        static /*0x291fe50*/ int GetContacts(UnityEngine.Collider2D collider, UnityEngine.Collider2D[] colliders);
        static /*0x291ff88*/ int GetContacts(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] colliders);
        static /*0x2920020*/ int GetContacts(UnityEngine.Rigidbody2D rigidbody, UnityEngine.ContactPoint2D[] contacts);
        static /*0x2920158*/ int GetContacts(UnityEngine.Rigidbody2D rigidbody, UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] contacts);
        static /*0x29201f0*/ int GetContacts(UnityEngine.Rigidbody2D rigidbody, UnityEngine.Collider2D[] colliders);
        static /*0x2920328*/ int GetContacts(UnityEngine.Rigidbody2D rigidbody, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] colliders);
        static /*0x291fd2c*/ int GetColliderContactsArray(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] results);
        static /*0x291fb90*/ int GetColliderColliderContactsArray(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] results);
        static /*0x29200cc*/ int GetRigidbodyContactsArray(UnityEngine.Rigidbody2D rigidbody, UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] results);
        static /*0x291fefc*/ int GetColliderContactsCollidersOnlyArray(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x292029c*/ int GetRigidbodyContactsCollidersOnlyArray(UnityEngine.Rigidbody2D rigidbody, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x292056c*/ int GetContacts(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> contacts);
        static /*0x29206b0*/ int GetContacts(UnityEngine.Collider2D collider, System.Collections.Generic.List<UnityEngine.ContactPoint2D> contacts);
        static /*0x29207e8*/ int GetContacts(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> contacts);
        static /*0x2920880*/ int GetContacts(UnityEngine.Collider2D collider, System.Collections.Generic.List<UnityEngine.Collider2D> colliders);
        static /*0x29209b8*/ int GetContacts(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> colliders);
        static /*0x2920a50*/ int GetContacts(UnityEngine.Rigidbody2D rigidbody, System.Collections.Generic.List<UnityEngine.ContactPoint2D> contacts);
        static /*0x2920b88*/ int GetContacts(UnityEngine.Rigidbody2D rigidbody, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> contacts);
        static /*0x2920c20*/ int GetContacts(UnityEngine.Rigidbody2D rigidbody, System.Collections.Generic.List<UnityEngine.Collider2D> colliders);
        static /*0x2920d58*/ int GetContacts(UnityEngine.Rigidbody2D rigidbody, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> colliders);
        static /*0x292075c*/ int GetColliderContactsList(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> results);
        static /*0x2920614*/ int GetColliderColliderContactsList(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> results);
        static /*0x2920afc*/ int GetRigidbodyContactsList(UnityEngine.Rigidbody2D rigidbody, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> results);
        static /*0x292092c*/ int GetColliderContactsCollidersOnlyList(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        static /*0x2920ccc*/ int GetRigidbodyContactsCollidersOnlyList(UnityEngine.Rigidbody2D rigidbody, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        static /*0x2920f9c*/ void SetEditorDragMovement(bool dragging, UnityEngine.GameObject[] objs);
        static /*0x2913f58*/ void get_gravity_Injected(ref UnityEngine.Vector2 ret);
        static /*0x291400c*/ void set_gravity_Injected(ref UnityEngine.Vector2 value);
        static /*0x291433c*/ void get_jobOptions_Injected(ref UnityEngine.PhysicsJobOptions2D ret);
        static /*0x29143ec*/ void set_jobOptions_Injected(ref UnityEngine.PhysicsJobOptions2D value);
        static /*0x2914ac0*/ void get_colliderAwakeColor_Injected(ref UnityEngine.Color ret);
        static /*0x2914b80*/ void set_colliderAwakeColor_Injected(ref UnityEngine.Color value);
        static /*0x2914c44*/ void get_colliderAsleepColor_Injected(ref UnityEngine.Color ret);
        static /*0x2914d04*/ void set_colliderAsleepColor_Injected(ref UnityEngine.Color value);
        static /*0x2914dc8*/ void get_colliderContactColor_Injected(ref UnityEngine.Color ret);
        static /*0x2914e88*/ void set_colliderContactColor_Injected(ref UnityEngine.Color value);
        static /*0x2914f4c*/ void get_colliderAABBColor_Injected(ref UnityEngine.Color ret);
        static /*0x291500c*/ void set_colliderAABBColor_Injected(ref UnityEngine.Color value);
        static /*0x29150a8*/ bool Simulate_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, float step);
        static /*0x29158c8*/ bool IsTouching_TwoCollidersWithFilter_Injected(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, ref UnityEngine.ContactFilter2D contactFilter);
        static /*0x2915a34*/ bool IsTouching_SingleColliderWithFilter_Injected(UnityEngine.Collider2D collider, ref UnityEngine.ContactFilter2D contactFilter);
        static /*0x2915d8c*/ void Distance_Internal_Injected(UnityEngine.Collider2D colliderA, UnityEngine.Collider2D colliderB, ref UnityEngine.ColliderDistance2D ret);
        static /*0x29160e8*/ void ClosestPoint_Collider_Injected(ref UnityEngine.Vector2 position, UnityEngine.Collider2D collider, ref UnityEngine.Vector2 ret);
        static /*0x291613c*/ void ClosestPoint_Rigidbody_Injected(ref UnityEngine.Vector2 position, UnityEngine.Rigidbody2D rigidbody, ref UnityEngine.Vector2 ret);
        static /*0x2916abc*/ UnityEngine.RaycastHit2D[] LinecastAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 start, ref UnityEngine.Vector2 end, ref UnityEngine.ContactFilter2D contactFilter);
        static /*0x2917e94*/ UnityEngine.RaycastHit2D[] RaycastAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter);
        static /*0x2918bb4*/ UnityEngine.RaycastHit2D[] CircleCastAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, float radius, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter);
        static /*0x2919e40*/ UnityEngine.RaycastHit2D[] BoxCastAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 size, float angle, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter);
        static /*0x291aed8*/ UnityEngine.RaycastHit2D[] CapsuleCastAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter);
        static /*0x291bc5c*/ UnityEngine.RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 direction, float distance, int layerMask);
        static /*0x291c5ec*/ UnityEngine.Collider2D[] OverlapPointAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.ContactFilter2D contactFilter);
        static /*0x291d114*/ UnityEngine.Collider2D[] OverlapCircleAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, float radius, ref UnityEngine.ContactFilter2D contactFilter);
        static /*0x291dd74*/ UnityEngine.Collider2D[] OverlapBoxAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.Vector2 size, float angle, ref UnityEngine.ContactFilter2D contactFilter);
        static /*0x291f600*/ UnityEngine.Collider2D[] OverlapCapsuleAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, ref UnityEngine.ContactFilter2D contactFilter);
        static /*0x29203c0*/ int GetColliderContactsArray_Injected(UnityEngine.Collider2D collider, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] results);
        static /*0x2920414*/ int GetColliderColliderContactsArray_Injected(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] results);
        static /*0x2920470*/ int GetRigidbodyContactsArray_Injected(UnityEngine.Rigidbody2D rigidbody, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] results);
        static /*0x29204c4*/ int GetColliderContactsCollidersOnlyArray_Injected(UnityEngine.Collider2D collider, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x2920518*/ int GetRigidbodyContactsCollidersOnlyArray_Injected(UnityEngine.Rigidbody2D rigidbody, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        static /*0x2920df0*/ int GetColliderContactsList_Injected(UnityEngine.Collider2D collider, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> results);
        static /*0x2920e44*/ int GetColliderColliderContactsList_Injected(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> results);
        static /*0x2920ea0*/ int GetRigidbodyContactsList_Injected(UnityEngine.Rigidbody2D rigidbody, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> results);
        static /*0x2920ef4*/ int GetColliderContactsCollidersOnlyList_Injected(UnityEngine.Collider2D collider, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        static /*0x2920f48*/ int GetRigidbodyContactsCollidersOnlyList_Injected(UnityEngine.Rigidbody2D rigidbody, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        /*0x2921388*/ Physics2D();
    }

    enum SimulationMode2D
    {
        FixedUpdate = 0,
        Update = 1,
        Script = 2,
    }

    enum CapsuleDirection2D
    {
        Vertical = 0,
        Horizontal = 1,
    }

    enum RigidbodyConstraints2D
    {
        None = 0,
        FreezePositionX = 1,
        FreezePositionY = 2,
        FreezeRotation = 4,
        FreezePosition = 3,
        FreezeAll = 7,
    }

    enum RigidbodyInterpolation2D
    {
        None = 0,
        Interpolate = 1,
        Extrapolate = 2,
    }

    enum RigidbodySleepMode2D
    {
        NeverSleep = 0,
        StartAwake = 1,
        StartAsleep = 2,
    }

    enum CollisionDetectionMode2D
    {
        None = 0,
        Discrete = 0,
        Continuous = 1,
    }

    enum RigidbodyType2D
    {
        Dynamic = 0,
        Kinematic = 1,
        Static = 2,
    }

    enum ForceMode2D
    {
        Force = 0,
        Impulse = 1,
    }

    enum ColliderErrorState2D
    {
        None = 0,
        NoShapes = 1,
        RemovedShapes = 2,
    }

    enum JointLimitState2D
    {
        Inactive = 0,
        LowerLimit = 1,
        UpperLimit = 2,
        EqualLimits = 3,
    }

    enum EffectorSelection2D
    {
        Rigidbody = 0,
        Collider = 1,
    }

    enum EffectorForceMode2D
    {
        Constant = 0,
        InverseLinear = 1,
        InverseSquared = 2,
    }

    enum PhysicsShapeType2D
    {
        Circle = 0,
        Capsule = 1,
        Polygon = 2,
        Edges = 3,
    }

    struct PhysicsShape2D
    {
        /*0x10*/ UnityEngine.PhysicsShapeType2D m_ShapeType;
        /*0x14*/ float m_Radius;
        /*0x18*/ int m_VertexStartIndex;
        /*0x1c*/ int m_VertexCount;
        /*0x20*/ int m_UseAdjacentStart;
        /*0x24*/ int m_UseAdjacentEnd;
        /*0x28*/ UnityEngine.Vector2 m_AdjacentStart;
        /*0x30*/ UnityEngine.Vector2 m_AdjacentEnd;

        /*0x292141c*/ UnityEngine.PhysicsShapeType2D get_shapeType();
        /*0x2921424*/ void set_shapeType(UnityEngine.PhysicsShapeType2D value);
        /*0x292142c*/ float get_radius();
        /*0x2921434*/ void set_radius(float value);
        /*0x2921578*/ int get_vertexStartIndex();
        /*0x2921580*/ void set_vertexStartIndex(int value);
        /*0x29215e0*/ int get_vertexCount();
        /*0x29215e8*/ void set_vertexCount(int value);
        /*0x292164c*/ bool get_useAdjacentStart();
        /*0x292165c*/ void set_useAdjacentStart(bool value);
        /*0x2921668*/ bool get_useAdjacentEnd();
        /*0x2921678*/ void set_useAdjacentEnd(bool value);
        /*0x2921684*/ UnityEngine.Vector2 get_adjacentStart();
        /*0x292168c*/ void set_adjacentStart(UnityEngine.Vector2 value);
        /*0x292180c*/ UnityEngine.Vector2 get_adjacentEnd();
        /*0x2921814*/ void set_adjacentEnd(UnityEngine.Vector2 value);
    }

    class PhysicsShapeGroup2D
    {
        static float MinVertexSeparation = 0.0024999999441206455;
        /*0x10*/ UnityEngine.PhysicsShapeGroup2D.GroupState m_GroupState;

        static /*0x2923730*/ UnityEngine.Vector2 <AddBox>g__Rotate|28_0(float cos, float sin, UnityEngine.Vector2 value);
        /*0x2921a5c*/ PhysicsShapeGroup2D(int shapeCapacity, int vertexCapacity);
        /*0x2921994*/ System.Collections.Generic.List<UnityEngine.Vector2> get_groupVertices();
        /*0x292199c*/ System.Collections.Generic.List<UnityEngine.PhysicsShape2D> get_groupShapes();
        /*0x29219a4*/ int get_shapeCount();
        /*0x29219ec*/ int get_vertexCount();
        /*0x2921a34*/ UnityEngine.Matrix4x4 get_localToWorldMatrix();
        /*0x2921a48*/ void set_localToWorldMatrix(UnityEngine.Matrix4x4 value);
        /*0x2921b8c*/ void Clear();
        /*0x2921c5c*/ void Add(UnityEngine.PhysicsShapeGroup2D physicsShapeGroup);
        /*0x2921e78*/ void GetShapeData(System.Collections.Generic.List<UnityEngine.PhysicsShape2D> shapes, System.Collections.Generic.List<UnityEngine.Vector2> vertices);
        /*0x2921f04*/ void GetShapeData(Unity.Collections.NativeArray<UnityEngine.PhysicsShape2D> shapes, Unity.Collections.NativeArray<UnityEngine.Vector2> vertices);
        /*0x2922194*/ void GetShapeVertices(int shapeIndex, System.Collections.Generic.List<UnityEngine.Vector2> vertices);
        /*0x2922458*/ UnityEngine.Vector2 GetShapeVertex(int shapeIndex, int vertexIndex);
        /*0x2922594*/ void SetShapeVertex(int shapeIndex, int vertexIndex, UnityEngine.Vector2 vertex);
        /*0x29226e8*/ void SetShapeRadius(int shapeIndex, float radius);
        /*0x2922884*/ void SetShapeAdjacentVertices(int shapeIndex, bool useAdjacentStart, bool useAdjacentEnd, UnityEngine.Vector2 adjacentStart, UnityEngine.Vector2 adjacentEnd);
        /*0x2922b1c*/ void DeleteShape(int shapeIndex);
        /*0x2922308*/ UnityEngine.PhysicsShape2D GetShape(int shapeIndex);
        /*0x2922d58*/ int AddCircle(UnityEngine.Vector2 center, float radius);
        /*0x2922fb8*/ int AddCapsule(UnityEngine.Vector2 vertex0, UnityEngine.Vector2 vertex1, float radius);
        /*0x29232a4*/ int AddBox(UnityEngine.Vector2 center, UnityEngine.Vector2 size, float angle, float edgeRadius);
        /*0x292374c*/ int AddPolygon(System.Collections.Generic.List<UnityEngine.Vector2> vertices);
        /*0x2923aac*/ int AddEdges(System.Collections.Generic.List<UnityEngine.Vector2> vertices, float edgeRadius);
        /*0x2923b24*/ int AddEdges(System.Collections.Generic.List<UnityEngine.Vector2> vertices, bool useAdjacentStart, bool useAdjacentEnd, UnityEngine.Vector2 adjacentStart, UnityEngine.Vector2 adjacentEnd, float edgeRadius);

        struct GroupState
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.PhysicsShape2D> m_Shapes;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Vector2> m_Vertices;
            /*0x20*/ UnityEngine.Matrix4x4 m_LocalToWorld;

            /*0x2921bec*/ void ClearGeometry();
        }
    }

    struct ColliderDistance2D
    {
        /*0x10*/ UnityEngine.Vector2 m_PointA;
        /*0x18*/ UnityEngine.Vector2 m_PointB;
        /*0x20*/ UnityEngine.Vector2 m_Normal;
        /*0x28*/ float m_Distance;
        /*0x2c*/ int m_IsValid;

        /*0x2923db4*/ UnityEngine.Vector2 get_pointA();
        /*0x2923dbc*/ void set_pointA(UnityEngine.Vector2 value);
        /*0x2923dc4*/ UnityEngine.Vector2 get_pointB();
        /*0x2923dcc*/ void set_pointB(UnityEngine.Vector2 value);
        /*0x2923dd4*/ UnityEngine.Vector2 get_normal();
        /*0x2923ddc*/ float get_distance();
        /*0x2923de4*/ void set_distance(float value);
        /*0x2923dec*/ bool get_isOverlapped();
        /*0x2923dfc*/ bool get_isValid();
        /*0x2923e0c*/ void set_isValid(bool value);
    }

    struct ContactFilter2D
    {
        static float NormalAngleUpperLimit = 359.9999084472656;
        /*0x10*/ bool useTriggers;
        /*0x11*/ bool useLayerMask;
        /*0x12*/ bool useDepth;
        /*0x13*/ bool useOutsideDepth;
        /*0x14*/ bool useNormalAngle;
        /*0x15*/ bool useOutsideNormalAngle;
        /*0x18*/ UnityEngine.LayerMask layerMask;
        /*0x1c*/ float minDepth;
        /*0x20*/ float maxDepth;
        /*0x24*/ float minNormalAngle;
        /*0x28*/ float maxNormalAngle;

        static /*0x2910450*/ UnityEngine.ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth);
        static /*0x2923e54*/ void CheckConsistency_Injected(ref UnityEngine.ContactFilter2D _unity_self);
        static /*0x2924138*/ bool IsFilteringNormalAngle_Injected(ref UnityEngine.ContactFilter2D _unity_self, ref UnityEngine.Vector2 normal);
        static /*0x2924214*/ bool IsFilteringNormalAngleUsingAngle_Injected(ref UnityEngine.ContactFilter2D _unity_self, float angle);
        /*0x291fcd8*/ UnityEngine.ContactFilter2D NoFilter();
        /*0x2923e18*/ void CheckConsistency();
        /*0x2923e90*/ void ClearLayerMask();
        /*0x2923e98*/ void SetLayerMask(UnityEngine.LayerMask layerMask);
        /*0x2923ea8*/ void ClearDepth();
        /*0x2923eb0*/ void SetDepth(float minDepth, float maxDepth);
        /*0x2923ef8*/ void ClearNormalAngle();
        /*0x2923f00*/ void SetNormalAngle(float minNormalAngle, float maxNormalAngle);
        /*0x2923f48*/ bool get_isFiltering();
        /*0x2923f78*/ bool IsFilteringTrigger(UnityEngine.Collider2D collider);
        /*0x2924010*/ bool IsFilteringLayerMask(UnityEngine.GameObject obj);
        /*0x292406c*/ bool IsFilteringDepth(UnityEngine.GameObject obj);
        /*0x29240ec*/ bool IsFilteringNormalAngle(UnityEngine.Vector2 normal);
        /*0x292417c*/ bool IsFilteringNormalAngle(float angle);
        /*0x29241c8*/ bool IsFilteringNormalAngleUsingAngle(float angle);
    }

    class Collision2D
    {
        /*0x10*/ int m_Collider;
        /*0x14*/ int m_OtherCollider;
        /*0x18*/ int m_Rigidbody;
        /*0x1c*/ int m_OtherRigidbody;
        /*0x20*/ UnityEngine.Vector2 m_RelativeVelocity;
        /*0x28*/ int m_Enabled;
        /*0x2c*/ int m_ContactCount;
        /*0x30*/ UnityEngine.ContactPoint2D[] m_ReusedContacts;
        /*0x38*/ UnityEngine.ContactPoint2D[] m_LegacyContacts;

        /*0x2924a28*/ Collision2D();
        /*0x2924260*/ UnityEngine.ContactPoint2D[] GetContacts_Internal();
        /*0x292427c*/ UnityEngine.Collider2D get_collider();
        /*0x2924328*/ UnityEngine.Collider2D get_otherCollider();
        /*0x29243d4*/ UnityEngine.Rigidbody2D get_rigidbody();
        /*0x292445c*/ UnityEngine.Rigidbody2D get_otherRigidbody();
        /*0x29244e4*/ UnityEngine.Transform get_transform();
        /*0x2924578*/ UnityEngine.GameObject get_gameObject();
        /*0x292460c*/ UnityEngine.Vector2 get_relativeVelocity();
        /*0x2924614*/ bool get_enabled();
        /*0x2924624*/ UnityEngine.ContactPoint2D[] get_contacts();
        /*0x2924698*/ int get_contactCount();
        /*0x29246a0*/ UnityEngine.ContactPoint2D GetContact(int index);
        /*0x29247bc*/ int GetContacts(UnityEngine.ContactPoint2D[] contacts);
        /*0x2924850*/ int GetContacts(System.Collections.Generic.List<UnityEngine.ContactPoint2D> contacts);
    }

    struct ContactPoint2D
    {
        /*0x10*/ UnityEngine.Vector2 m_Point;
        /*0x18*/ UnityEngine.Vector2 m_Normal;
        /*0x20*/ UnityEngine.Vector2 m_RelativeVelocity;
        /*0x28*/ float m_Separation;
        /*0x2c*/ float m_NormalImpulse;
        /*0x30*/ float m_TangentImpulse;
        /*0x34*/ int m_Collider;
        /*0x38*/ int m_OtherCollider;
        /*0x3c*/ int m_Rigidbody;
        /*0x40*/ int m_OtherRigidbody;
        /*0x44*/ int m_Enabled;

        /*0x2924a30*/ UnityEngine.Vector2 get_point();
        /*0x2924a38*/ UnityEngine.Vector2 get_normal();
        /*0x2924a40*/ float get_separation();
        /*0x2924a48*/ float get_normalImpulse();
        /*0x2924a50*/ float get_tangentImpulse();
        /*0x2924a58*/ UnityEngine.Vector2 get_relativeVelocity();
        /*0x2924a60*/ UnityEngine.Collider2D get_collider();
        /*0x2924b0c*/ UnityEngine.Collider2D get_otherCollider();
        /*0x2924bb8*/ UnityEngine.Rigidbody2D get_rigidbody();
        /*0x2924c40*/ UnityEngine.Rigidbody2D get_otherRigidbody();
        /*0x2924cc8*/ bool get_enabled();
    }

    struct JointAngleLimits2D
    {
        /*0x10*/ float m_LowerAngle;
        /*0x14*/ float m_UpperAngle;

        /*0x2924cd8*/ float get_min();
        /*0x2924ce0*/ void set_min(float value);
        /*0x2924ce8*/ float get_max();
        /*0x2924cf0*/ void set_max(float value);
    }

    struct JointTranslationLimits2D
    {
        /*0x10*/ float m_LowerTranslation;
        /*0x14*/ float m_UpperTranslation;

        /*0x2924cf8*/ float get_min();
        /*0x2924d00*/ void set_min(float value);
        /*0x2924d08*/ float get_max();
        /*0x2924d10*/ void set_max(float value);
    }

    struct JointMotor2D
    {
        /*0x10*/ float m_MotorSpeed;
        /*0x14*/ float m_MaximumMotorTorque;

        /*0x2924d18*/ float get_motorSpeed();
        /*0x2924d20*/ void set_motorSpeed(float value);
        /*0x2924d28*/ float get_maxMotorTorque();
        /*0x2924d30*/ void set_maxMotorTorque(float value);
    }

    struct JointSuspension2D
    {
        /*0x10*/ float m_DampingRatio;
        /*0x14*/ float m_Frequency;
        /*0x18*/ float m_Angle;

        /*0x2924d38*/ float get_dampingRatio();
        /*0x2924d40*/ void set_dampingRatio(float value);
        /*0x2924d48*/ float get_frequency();
        /*0x2924d50*/ void set_frequency(float value);
        /*0x2924d58*/ float get_angle();
        /*0x2924d60*/ void set_angle(float value);
    }

    struct RaycastHit2D
    {
        /*0x10*/ UnityEngine.Vector2 m_Centroid;
        /*0x18*/ UnityEngine.Vector2 m_Point;
        /*0x20*/ UnityEngine.Vector2 m_Normal;
        /*0x28*/ float m_Distance;
        /*0x2c*/ float m_Fraction;
        /*0x30*/ int m_Collider;

        static /*0x2925038*/ bool op_Implicit(UnityEngine.RaycastHit2D hit);
        /*0x2924d68*/ UnityEngine.Vector2 get_centroid();
        /*0x2924d70*/ void set_centroid(UnityEngine.Vector2 value);
        /*0x2924d78*/ UnityEngine.Vector2 get_point();
        /*0x2924d80*/ void set_point(UnityEngine.Vector2 value);
        /*0x2924d88*/ UnityEngine.Vector2 get_normal();
        /*0x2924d90*/ void set_normal(UnityEngine.Vector2 value);
        /*0x2924d98*/ float get_distance();
        /*0x2924da0*/ void set_distance(float value);
        /*0x2924da8*/ float get_fraction();
        /*0x2924db0*/ void set_fraction(float value);
        /*0x2924db8*/ UnityEngine.Collider2D get_collider();
        /*0x2924e64*/ UnityEngine.Rigidbody2D get_rigidbody();
        /*0x2924f5c*/ UnityEngine.Transform get_transform();
        /*0x29250a4*/ int CompareTo(UnityEngine.RaycastHit2D other);
    }

    struct PhysicsJobOptions2D
    {
        /*0x10*/ bool m_UseMultithreading;
        /*0x11*/ bool m_UseConsistencySorting;
        /*0x14*/ int m_InterpolationPosesPerJob;
        /*0x18*/ int m_NewContactsPerJob;
        /*0x1c*/ int m_CollideContactsPerJob;
        /*0x20*/ int m_ClearFlagsPerJob;
        /*0x24*/ int m_ClearBodyForcesPerJob;
        /*0x28*/ int m_SyncDiscreteFixturesPerJob;
        /*0x2c*/ int m_SyncContinuousFixturesPerJob;
        /*0x30*/ int m_FindNearestContactsPerJob;
        /*0x34*/ int m_UpdateTriggerContactsPerJob;
        /*0x38*/ int m_IslandSolverCostThreshold;
        /*0x3c*/ int m_IslandSolverBodyCostScale;
        /*0x40*/ int m_IslandSolverContactCostScale;
        /*0x44*/ int m_IslandSolverJointCostScale;
        /*0x48*/ int m_IslandSolverBodiesPerJob;
        /*0x4c*/ int m_IslandSolverContactsPerJob;

        /*0x2925184*/ bool get_useMultithreading();
        /*0x292518c*/ void set_useMultithreading(bool value);
        /*0x2925198*/ bool get_useConsistencySorting();
        /*0x29251a0*/ void set_useConsistencySorting(bool value);
        /*0x29251ac*/ int get_interpolationPosesPerJob();
        /*0x29251b4*/ void set_interpolationPosesPerJob(int value);
        /*0x29251bc*/ int get_newContactsPerJob();
        /*0x29251c4*/ void set_newContactsPerJob(int value);
        /*0x29251cc*/ int get_collideContactsPerJob();
        /*0x29251d4*/ void set_collideContactsPerJob(int value);
        /*0x29251dc*/ int get_clearFlagsPerJob();
        /*0x29251e4*/ void set_clearFlagsPerJob(int value);
        /*0x29251ec*/ int get_clearBodyForcesPerJob();
        /*0x29251f4*/ void set_clearBodyForcesPerJob(int value);
        /*0x29251fc*/ int get_syncDiscreteFixturesPerJob();
        /*0x2925204*/ void set_syncDiscreteFixturesPerJob(int value);
        /*0x292520c*/ int get_syncContinuousFixturesPerJob();
        /*0x2925214*/ void set_syncContinuousFixturesPerJob(int value);
        /*0x292521c*/ int get_findNearestContactsPerJob();
        /*0x2925224*/ void set_findNearestContactsPerJob(int value);
        /*0x292522c*/ int get_updateTriggerContactsPerJob();
        /*0x2925234*/ void set_updateTriggerContactsPerJob(int value);
        /*0x292523c*/ int get_islandSolverCostThreshold();
        /*0x2925244*/ void set_islandSolverCostThreshold(int value);
        /*0x292524c*/ int get_islandSolverBodyCostScale();
        /*0x2925254*/ void set_islandSolverBodyCostScale(int value);
        /*0x292525c*/ int get_islandSolverContactCostScale();
        /*0x2925264*/ void set_islandSolverContactCostScale(int value);
        /*0x292526c*/ int get_islandSolverJointCostScale();
        /*0x2925274*/ void set_islandSolverJointCostScale(int value);
        /*0x292527c*/ int get_islandSolverBodiesPerJob();
        /*0x2925284*/ void set_islandSolverBodiesPerJob(int value);
        /*0x292528c*/ int get_islandSolverContactsPerJob();
        /*0x2925294*/ void set_islandSolverContactsPerJob(int value);
    }

    class Rigidbody2D : UnityEngine.Component
    {
        /*0x2927e24*/ Rigidbody2D();
        /*0x292529c*/ UnityEngine.Vector2 get_position();
        /*0x292532c*/ void set_position(UnityEngine.Vector2 value);
        /*0x29253b8*/ float get_rotation();
        /*0x29253f4*/ void set_rotation(float value);
        /*0x2925440*/ void SetRotation(float angle);
        /*0x292548c*/ void SetRotation_Angle(float angle);
        /*0x29254d8*/ void SetRotation(UnityEngine.Quaternion rotation);
        /*0x29254dc*/ void SetRotation_Quaternion(UnityEngine.Quaternion rotation);
        /*0x2925574*/ void MovePosition(UnityEngine.Vector2 position);
        /*0x2925600*/ void MoveRotation(float angle);
        /*0x292564c*/ void MoveRotation_Angle(float angle);
        /*0x2925698*/ void MoveRotation(UnityEngine.Quaternion rotation);
        /*0x292569c*/ void MoveRotation_Quaternion(UnityEngine.Quaternion rotation);
        /*0x2925734*/ UnityEngine.Vector2 get_velocity();
        /*0x29257c4*/ void set_velocity(UnityEngine.Vector2 value);
        /*0x2925850*/ float get_angularVelocity();
        /*0x292588c*/ void set_angularVelocity(float value);
        /*0x29258d8*/ bool get_useAutoMass();
        /*0x2925914*/ void set_useAutoMass(bool value);
        /*0x2925958*/ float get_mass();
        /*0x2925994*/ void set_mass(float value);
        /*0x29259e0*/ UnityEngine.PhysicsMaterial2D get_sharedMaterial();
        /*0x2925a1c*/ void set_sharedMaterial(UnityEngine.PhysicsMaterial2D value);
        /*0x2925a60*/ UnityEngine.Vector2 get_centerOfMass();
        /*0x2925af0*/ void set_centerOfMass(UnityEngine.Vector2 value);
        /*0x2925b7c*/ UnityEngine.Vector2 get_worldCenterOfMass();
        /*0x2925c0c*/ float get_inertia();
        /*0x2925c48*/ void set_inertia(float value);
        /*0x2925c94*/ float get_drag();
        /*0x2925cd0*/ void set_drag(float value);
        /*0x2925d1c*/ float get_angularDrag();
        /*0x2925d58*/ void set_angularDrag(float value);
        /*0x2925da4*/ float get_gravityScale();
        /*0x2925de0*/ void set_gravityScale(float value);
        /*0x2925e2c*/ UnityEngine.RigidbodyType2D get_bodyType();
        /*0x2925e68*/ void set_bodyType(UnityEngine.RigidbodyType2D value);
        /*0x2921344*/ void SetDragBehaviour(bool dragged);
        /*0x2925eac*/ bool get_useFullKinematicContacts();
        /*0x2925ee8*/ void set_useFullKinematicContacts(bool value);
        /*0x2925f2c*/ bool get_isKinematic();
        /*0x2925f74*/ void set_isKinematic(bool value);
        /*0x2925fc0*/ bool get_fixedAngle();
        /*0x2925ffc*/ void set_fixedAngle(bool value);
        /*0x2926040*/ bool get_freezeRotation();
        /*0x292607c*/ void set_freezeRotation(bool value);
        /*0x29260c0*/ UnityEngine.RigidbodyConstraints2D get_constraints();
        /*0x29260fc*/ void set_constraints(UnityEngine.RigidbodyConstraints2D value);
        /*0x2926140*/ bool IsSleeping();
        /*0x292617c*/ bool IsAwake();
        /*0x29261b8*/ void Sleep();
        /*0x29261f4*/ void WakeUp();
        /*0x2926230*/ bool get_simulated();
        /*0x292626c*/ void set_simulated(bool value);
        /*0x29262b0*/ UnityEngine.RigidbodyInterpolation2D get_interpolation();
        /*0x29262ec*/ void set_interpolation(UnityEngine.RigidbodyInterpolation2D value);
        /*0x2926330*/ UnityEngine.RigidbodySleepMode2D get_sleepMode();
        /*0x292636c*/ void set_sleepMode(UnityEngine.RigidbodySleepMode2D value);
        /*0x29263b0*/ UnityEngine.CollisionDetectionMode2D get_collisionDetectionMode();
        /*0x29263ec*/ void set_collisionDetectionMode(UnityEngine.CollisionDetectionMode2D value);
        /*0x2926430*/ int get_attachedColliderCount();
        /*0x292646c*/ bool IsTouching(UnityEngine.Collider2D collider);
        /*0x29264b0*/ bool IsTouching(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter);
        /*0x2926518*/ bool IsTouching_OtherColliderWithFilter_Internal(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter);
        /*0x29265c0*/ bool IsTouching(UnityEngine.ContactFilter2D contactFilter);
        /*0x2926620*/ bool IsTouching_AnyColliderWithFilter_Internal(UnityEngine.ContactFilter2D contactFilter);
        /*0x29266a8*/ bool IsTouchingLayers();
        /*0x29266e8*/ bool IsTouchingLayers(int layerMask);
        /*0x292672c*/ bool OverlapPoint(UnityEngine.Vector2 point);
        /*0x29267bc*/ UnityEngine.ColliderDistance2D Distance(UnityEngine.Collider2D collider);
        /*0x2926964*/ UnityEngine.ColliderDistance2D Distance_Internal(UnityEngine.Collider2D collider);
        /*0x2926a28*/ UnityEngine.Vector2 ClosestPoint(UnityEngine.Vector2 position);
        /*0x2926a94*/ void AddForce(UnityEngine.Vector2 force);
        /*0x2926a9c*/ void AddForce(UnityEngine.Vector2 force, UnityEngine.ForceMode2D mode);
        /*0x2926b48*/ void AddRelativeForce(UnityEngine.Vector2 relativeForce);
        /*0x2926b50*/ void AddRelativeForce(UnityEngine.Vector2 relativeForce, UnityEngine.ForceMode2D mode);
        /*0x2926bfc*/ void AddForceAtPosition(UnityEngine.Vector2 force, UnityEngine.Vector2 position);
        /*0x2926c04*/ void AddForceAtPosition(UnityEngine.Vector2 force, UnityEngine.Vector2 position, UnityEngine.ForceMode2D mode);
        /*0x2926cc0*/ void AddTorque(float torque);
        /*0x2926d10*/ void AddTorque(float torque, UnityEngine.ForceMode2D mode);
        /*0x2926d64*/ UnityEngine.Vector2 GetPoint(UnityEngine.Vector2 point);
        /*0x2926e10*/ UnityEngine.Vector2 GetRelativePoint(UnityEngine.Vector2 relativePoint);
        /*0x2926ebc*/ UnityEngine.Vector2 GetVector(UnityEngine.Vector2 vector);
        /*0x2926f68*/ UnityEngine.Vector2 GetRelativeVector(UnityEngine.Vector2 relativeVector);
        /*0x2927014*/ UnityEngine.Vector2 GetPointVelocity(UnityEngine.Vector2 point);
        /*0x29270c0*/ UnityEngine.Vector2 GetRelativePointVelocity(UnityEngine.Vector2 relativePoint);
        /*0x292716c*/ int OverlapCollider(UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        /*0x29271d0*/ int OverlapColliderArray_Internal(UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        /*0x2927278*/ int OverlapCollider(UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        /*0x29272dc*/ int OverlapColliderList_Internal(UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        /*0x2927384*/ int GetContacts(UnityEngine.ContactPoint2D[] contacts);
        /*0x2927430*/ int GetContacts(System.Collections.Generic.List<UnityEngine.ContactPoint2D> contacts);
        /*0x29274dc*/ int GetContacts(UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] contacts);
        /*0x2927574*/ int GetContacts(UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> contacts);
        /*0x292760c*/ int GetContacts(UnityEngine.Collider2D[] colliders);
        /*0x29276b8*/ int GetContacts(System.Collections.Generic.List<UnityEngine.Collider2D> colliders);
        /*0x2927764*/ int GetContacts(UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] colliders);
        /*0x29277fc*/ int GetContacts(UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> colliders);
        /*0x2927894*/ int GetAttachedColliders(UnityEngine.Collider2D[] results);
        /*0x29278d8*/ int GetAttachedCollidersArray_Internal(UnityEngine.Collider2D[] results);
        /*0x292791c*/ int GetAttachedColliders(System.Collections.Generic.List<UnityEngine.Collider2D> results);
        /*0x2927960*/ int GetAttachedCollidersList_Internal(System.Collections.Generic.List<UnityEngine.Collider2D> results);
        /*0x29279a4*/ int Cast(UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results);
        /*0x2927a10*/ int Cast(UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance);
        /*0x29279b0*/ int CastArray_Internal(UnityEngine.Vector2 direction, float distance, UnityEngine.RaycastHit2D[] results);
        /*0x2927a78*/ int Cast(UnityEngine.Vector2 direction, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance);
        /*0x2927a7c*/ int CastList_Internal(UnityEngine.Vector2 direction, float distance, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        /*0x2927b40*/ int Cast(UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        /*0x2927bec*/ int Cast(UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance);
        /*0x2927b74*/ int CastFilteredArray_Internal(UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        /*0x2927c84*/ int Cast(UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance);
        /*0x2927cb0*/ int CastFilteredList_Internal(UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        /*0x2927d94*/ int GetShapes(UnityEngine.PhysicsShapeGroup2D physicsShapeGroup);
        /*0x2927de0*/ int GetShapes_Internal(ref UnityEngine.PhysicsShapeGroup2D.GroupState physicsShapeGroupState);
        /*0x29252e8*/ void get_position_Injected(ref UnityEngine.Vector2 ret);
        /*0x2925374*/ void set_position_Injected(ref UnityEngine.Vector2 value);
        /*0x2925530*/ void SetRotation_Quaternion_Injected(ref UnityEngine.Quaternion rotation);
        /*0x29255bc*/ void MovePosition_Injected(ref UnityEngine.Vector2 position);
        /*0x29256f0*/ void MoveRotation_Quaternion_Injected(ref UnityEngine.Quaternion rotation);
        /*0x2925780*/ void get_velocity_Injected(ref UnityEngine.Vector2 ret);
        /*0x292580c*/ void set_velocity_Injected(ref UnityEngine.Vector2 value);
        /*0x2925aac*/ void get_centerOfMass_Injected(ref UnityEngine.Vector2 ret);
        /*0x2925b38*/ void set_centerOfMass_Injected(ref UnityEngine.Vector2 value);
        /*0x2925bc8*/ void get_worldCenterOfMass_Injected(ref UnityEngine.Vector2 ret);
        /*0x292656c*/ bool IsTouching_OtherColliderWithFilter_Internal_Injected(UnityEngine.Collider2D collider, ref UnityEngine.ContactFilter2D contactFilter);
        /*0x2926664*/ bool IsTouching_AnyColliderWithFilter_Internal_Injected(ref UnityEngine.ContactFilter2D contactFilter);
        /*0x2926778*/ bool OverlapPoint_Injected(ref UnityEngine.Vector2 point);
        /*0x29269d4*/ void Distance_Internal_Injected(UnityEngine.Collider2D collider, ref UnityEngine.ColliderDistance2D ret);
        /*0x2926af4*/ void AddForce_Injected(ref UnityEngine.Vector2 force, UnityEngine.ForceMode2D mode);
        /*0x2926ba8*/ void AddRelativeForce_Injected(ref UnityEngine.Vector2 relativeForce, UnityEngine.ForceMode2D mode);
        /*0x2926c64*/ void AddForceAtPosition_Injected(ref UnityEngine.Vector2 force, ref UnityEngine.Vector2 position, UnityEngine.ForceMode2D mode);
        /*0x2926dbc*/ void GetPoint_Injected(ref UnityEngine.Vector2 point, ref UnityEngine.Vector2 ret);
        /*0x2926e68*/ void GetRelativePoint_Injected(ref UnityEngine.Vector2 relativePoint, ref UnityEngine.Vector2 ret);
        /*0x2926f14*/ void GetVector_Injected(ref UnityEngine.Vector2 vector, ref UnityEngine.Vector2 ret);
        /*0x2926fc0*/ void GetRelativeVector_Injected(ref UnityEngine.Vector2 relativeVector, ref UnityEngine.Vector2 ret);
        /*0x292706c*/ void GetPointVelocity_Injected(ref UnityEngine.Vector2 point, ref UnityEngine.Vector2 ret);
        /*0x2927118*/ void GetRelativePointVelocity_Injected(ref UnityEngine.Vector2 relativePoint, ref UnityEngine.Vector2 ret);
        /*0x2927224*/ int OverlapColliderArray_Internal_Injected(ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        /*0x2927330*/ int OverlapColliderList_Internal_Injected(ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        /*0x2927a14*/ int CastArray_Internal_Injected(ref UnityEngine.Vector2 direction, float distance, UnityEngine.RaycastHit2D[] results);
        /*0x2927adc*/ int CastList_Internal_Injected(ref UnityEngine.Vector2 direction, float distance, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        /*0x2927c18*/ int CastFilteredArray_Internal_Injected(ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        /*0x2927d28*/ int CastFilteredList_Internal_Injected(ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
    }

    class Collider2D : UnityEngine.Behaviour
    {
        /*0x2929c18*/ Collider2D();
        /*0x2927e2c*/ float get_density();
        /*0x2927e68*/ void set_density(float value);
        /*0x2923fd4*/ bool get_isTrigger();
        /*0x2927eb4*/ void set_isTrigger(bool value);
        /*0x2927ef8*/ bool get_usedByEffector();
        /*0x2927f34*/ void set_usedByEffector(bool value);
        /*0x2927f78*/ bool get_usedByComposite();
        /*0x2927fb4*/ void set_usedByComposite(bool value);
        /*0x2927ff8*/ UnityEngine.CompositeCollider2D get_composite();
        /*0x2928034*/ UnityEngine.Vector2 get_offset();
        /*0x29280c4*/ void set_offset(UnityEngine.Vector2 value);
        /*0x2924f20*/ UnityEngine.Rigidbody2D get_attachedRigidbody();
        /*0x2928150*/ int get_shapeCount();
        /*0x292818c*/ UnityEngine.Mesh CreateMesh(bool useBodyPosition, bool useBodyRotation);
        /*0x29281e0*/ uint GetShapeHash();
        /*0x292821c*/ int GetShapes(UnityEngine.PhysicsShapeGroup2D physicsShapeGroup);
        /*0x2928300*/ int GetShapes(UnityEngine.PhysicsShapeGroup2D physicsShapeGroup, int shapeIndex, int shapeCount);
        /*0x29282a4*/ int GetShapes_Internal(ref UnityEngine.PhysicsShapeGroup2D.GroupState physicsShapeGroupState, int shapeIndex, int shapeCount);
        /*0x2928478*/ UnityEngine.Bounds get_bounds();
        /*0x2928524*/ UnityEngine.ColliderErrorState2D get_errorState();
        /*0x2928560*/ bool get_compositeCapable();
        /*0x292859c*/ UnityEngine.PhysicsMaterial2D get_sharedMaterial();
        /*0x29285d8*/ void set_sharedMaterial(UnityEngine.PhysicsMaterial2D value);
        /*0x292861c*/ float get_friction();
        /*0x2928658*/ float get_bounciness();
        /*0x2928694*/ bool IsTouching(UnityEngine.Collider2D collider);
        /*0x29286d8*/ bool IsTouching(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter);
        /*0x2928740*/ bool IsTouching_OtherColliderWithFilter(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter);
        /*0x29287e8*/ bool IsTouching(UnityEngine.ContactFilter2D contactFilter);
        /*0x2928848*/ bool IsTouching_AnyColliderWithFilter(UnityEngine.ContactFilter2D contactFilter);
        /*0x29288d0*/ bool IsTouchingLayers();
        /*0x2928910*/ bool IsTouchingLayers(int layerMask);
        /*0x2928954*/ bool OverlapPoint(UnityEngine.Vector2 point);
        /*0x29289e4*/ UnityEngine.ColliderDistance2D Distance(UnityEngine.Collider2D collider);
        /*0x2928a6c*/ int OverlapCollider(UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results);
        /*0x2928ad0*/ int OverlapCollider(UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results);
        /*0x2928b34*/ int GetContacts(UnityEngine.ContactPoint2D[] contacts);
        /*0x2928be0*/ int GetContacts(System.Collections.Generic.List<UnityEngine.ContactPoint2D> contacts);
        /*0x2928c8c*/ int GetContacts(UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] contacts);
        /*0x2928d24*/ int GetContacts(UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> contacts);
        /*0x2928dbc*/ int GetContacts(UnityEngine.Collider2D[] colliders);
        /*0x2928e68*/ int GetContacts(System.Collections.Generic.List<UnityEngine.Collider2D> colliders);
        /*0x2928f14*/ int GetContacts(UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] colliders);
        /*0x2928fac*/ int GetContacts(UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> colliders);
        /*0x2929044*/ int Cast(UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results);
        /*0x29291dc*/ int Cast(UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance);
        /*0x2929304*/ int Cast(UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, bool ignoreSiblingColliders);
        /*0x2929430*/ int Cast(UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        /*0x292946c*/ int Cast(UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance);
        /*0x29294a0*/ int Cast(UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance, bool ignoreSiblingColliders);
        /*0x2929164*/ int CastArray_Internal(UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, bool ignoreSiblingColliders, UnityEngine.RaycastHit2D[] results);
        /*0x2929554*/ int Cast(UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance, bool ignoreSiblingColliders);
        /*0x292958c*/ int CastList_Internal(UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, bool ignoreSiblingColliders, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        /*0x2929680*/ int Raycast(UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results);
        /*0x292978c*/ int Raycast(UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance);
        /*0x2929820*/ int Raycast(UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask);
        /*0x29298b4*/ int Raycast(UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask, float minDepth);
        /*0x2929944*/ int Raycast(UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask, float minDepth, float maxDepth);
        /*0x29299d0*/ int Raycast(UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        /*0x2929a04*/ int Raycast(UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance);
        /*0x2929714*/ int RaycastArray_Internal(UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        /*0x2929a9c*/ int Raycast(UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance);
        /*0x2929ac8*/ int RaycastList_Internal(UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        /*0x2929bac*/ UnityEngine.Vector2 ClosestPoint(UnityEngine.Vector2 position);
        /*0x2928080*/ void get_offset_Injected(ref UnityEngine.Vector2 ret);
        /*0x292810c*/ void set_offset_Injected(ref UnityEngine.Vector2 value);
        /*0x29284e0*/ void get_bounds_Injected(ref UnityEngine.Bounds ret);
        /*0x2928794*/ bool IsTouching_OtherColliderWithFilter_Injected(UnityEngine.Collider2D collider, ref UnityEngine.ContactFilter2D contactFilter);
        /*0x292888c*/ bool IsTouching_AnyColliderWithFilter_Injected(ref UnityEngine.ContactFilter2D contactFilter);
        /*0x29289a0*/ bool OverlapPoint_Injected(ref UnityEngine.Vector2 point);
        /*0x29294d8*/ int CastArray_Internal_Injected(ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, bool ignoreSiblingColliders, UnityEngine.RaycastHit2D[] results);
        /*0x2929604*/ int CastList_Internal_Injected(ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, bool ignoreSiblingColliders, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
        /*0x2929a30*/ int RaycastArray_Internal_Injected(ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results);
        /*0x2929b40*/ int RaycastList_Internal_Injected(ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results);
    }

    class CustomCollider2D : UnityEngine.Collider2D
    {
        /*0x292ae3c*/ CustomCollider2D();
        /*0x2929c20*/ int get_customShapeCount();
        /*0x2929c5c*/ int get_customVertexCount();
        /*0x2929c98*/ int GetCustomShapes(UnityEngine.PhysicsShapeGroup2D physicsShapeGroup);
        /*0x2929da4*/ int GetCustomShapes(UnityEngine.PhysicsShapeGroup2D physicsShapeGroup, int shapeIndex, int shapeCount);
        /*0x2929d48*/ int GetCustomShapes_Internal(ref UnityEngine.PhysicsShapeGroup2D.GroupState physicsShapeGroupState, int shapeIndex, int shapeCount);
        /*0x2929f1c*/ int GetCustomShapes(Unity.Collections.NativeArray<UnityEngine.PhysicsShape2D> shapes, Unity.Collections.NativeArray<UnityEngine.Vector2> vertices);
        /*0x292a1a8*/ int GetCustomShapesNative_Internal(nint shapesPtr, int shapeCount, nint verticesPtr, int vertexCount);
        /*0x292a214*/ void SetCustomShapes(UnityEngine.PhysicsShapeGroup2D physicsShapeGroup);
        /*0x292a2a4*/ void SetCustomShapesAll_Internal(ref UnityEngine.PhysicsShapeGroup2D.GroupState physicsShapeGroupState);
        /*0x292a324*/ void SetCustomShapes(Unity.Collections.NativeArray<UnityEngine.PhysicsShape2D> shapes, Unity.Collections.NativeArray<UnityEngine.Vector2> vertices);
        /*0x292a4f8*/ void SetCustomShapesNative_Internal(nint shapesPtr, int shapeCount, nint verticesPtr, int vertexCount);
        /*0x292a564*/ void SetCustomShape(UnityEngine.PhysicsShapeGroup2D physicsShapeGroup, int srcShapeIndex, int dstShapeIndex);
        /*0x292a7a0*/ void SetCustomShape_Internal(ref UnityEngine.PhysicsShapeGroup2D.GroupState physicsShapeGroupState, int srcShapeIndex, int dstShapeIndex);
        /*0x292a7fc*/ void SetCustomShape(Unity.Collections.NativeArray<UnityEngine.PhysicsShape2D> shapes, Unity.Collections.NativeArray<UnityEngine.Vector2> vertices, int srcShapeIndex, int dstShapeIndex);
        /*0x292ab88*/ void SetCustomShapeNative_Internal(nint shapesPtr, int shapeCount, nint verticesPtr, int vertexCount, int srcShapeIndex, int dstShapeIndex);
        /*0x292ac0c*/ void ClearCustomShapes(int shapeIndex, int shapeCount);
        /*0x292ade8*/ void ClearCustomShapes_Internal(int shapeIndex, int shapeCount);
        /*0x292a2e8*/ void ClearCustomShapes();
    }

    class CircleCollider2D : UnityEngine.Collider2D
    {
        /*0x292aecc*/ CircleCollider2D();
        /*0x292ae44*/ float get_radius();
        /*0x292ae80*/ void set_radius(float value);
    }

    class CapsuleCollider2D : UnityEngine.Collider2D
    {
        /*0x292b070*/ CapsuleCollider2D();
        /*0x292aed4*/ UnityEngine.Vector2 get_size();
        /*0x292af64*/ void set_size(UnityEngine.Vector2 value);
        /*0x292aff0*/ UnityEngine.CapsuleDirection2D get_direction();
        /*0x292b02c*/ void set_direction(UnityEngine.CapsuleDirection2D value);
        /*0x292af20*/ void get_size_Injected(ref UnityEngine.Vector2 ret);
        /*0x292afac*/ void set_size_Injected(ref UnityEngine.Vector2 value);
    }

    class EdgeCollider2D : UnityEngine.Collider2D
    {
        /*0x292b5f4*/ EdgeCollider2D();
        /*0x292b078*/ void Reset();
        /*0x292b0b4*/ float get_edgeRadius();
        /*0x292b0f0*/ void set_edgeRadius(float value);
        /*0x292b13c*/ int get_edgeCount();
        /*0x292b178*/ int get_pointCount();
        /*0x292b1b4*/ UnityEngine.Vector2[] get_points();
        /*0x292b1f0*/ void set_points(UnityEngine.Vector2[] value);
        /*0x292b234*/ int GetPoints(System.Collections.Generic.List<UnityEngine.Vector2> points);
        /*0x292b278*/ bool SetPoints(System.Collections.Generic.List<UnityEngine.Vector2> points);
        /*0x292b2bc*/ bool get_useAdjacentStartPoint();
        /*0x292b2f8*/ void set_useAdjacentStartPoint(bool value);
        /*0x292b33c*/ bool get_useAdjacentEndPoint();
        /*0x292b378*/ void set_useAdjacentEndPoint(bool value);
        /*0x292b3bc*/ UnityEngine.Vector2 get_adjacentStartPoint();
        /*0x292b44c*/ void set_adjacentStartPoint(UnityEngine.Vector2 value);
        /*0x292b4d8*/ UnityEngine.Vector2 get_adjacentEndPoint();
        /*0x292b568*/ void set_adjacentEndPoint(UnityEngine.Vector2 value);
        /*0x292b408*/ void get_adjacentStartPoint_Injected(ref UnityEngine.Vector2 ret);
        /*0x292b494*/ void set_adjacentStartPoint_Injected(ref UnityEngine.Vector2 value);
        /*0x292b524*/ void get_adjacentEndPoint_Injected(ref UnityEngine.Vector2 ret);
        /*0x292b5b0*/ void set_adjacentEndPoint_Injected(ref UnityEngine.Vector2 value);
    }

    class BoxCollider2D : UnityEngine.Collider2D
    {
        /*0x292b820*/ BoxCollider2D();
        /*0x292b5fc*/ UnityEngine.Vector2 get_size();
        /*0x292b68c*/ void set_size(UnityEngine.Vector2 value);
        /*0x292b718*/ float get_edgeRadius();
        /*0x292b754*/ void set_edgeRadius(float value);
        /*0x292b7a0*/ bool get_autoTiling();
        /*0x292b7dc*/ void set_autoTiling(bool value);
        /*0x292b648*/ void get_size_Injected(ref UnityEngine.Vector2 ret);
        /*0x292b6d4*/ void set_size_Injected(ref UnityEngine.Vector2 value);
    }

    class PolygonCollider2D : UnityEngine.Collider2D
    {
        /*0x292c254*/ PolygonCollider2D();
        /*0x292b828*/ bool get_autoTiling();
        /*0x292b864*/ void set_autoTiling(bool value);
        /*0x292b8a8*/ int GetTotalPointCount();
        /*0x292b8e4*/ UnityEngine.Vector2[] get_points();
        /*0x292b920*/ void set_points(UnityEngine.Vector2[] value);
        /*0x292b964*/ int get_pathCount();
        /*0x292b9a0*/ void set_pathCount(int value);
        /*0x292b9e4*/ UnityEngine.Vector2[] GetPath(int index);
        /*0x292bb04*/ UnityEngine.Vector2[] GetPath_Internal(int index);
        /*0x292bb48*/ void SetPath(int index, UnityEngine.Vector2[] points);
        /*0x292bc18*/ void SetPath_Internal(int index, UnityEngine.Vector2[] points);
        /*0x292bc6c*/ int GetPath(int index, System.Collections.Generic.List<UnityEngine.Vector2> points);
        /*0x292bdf8*/ int GetPathList_Internal(int index, System.Collections.Generic.List<UnityEngine.Vector2> points);
        /*0x292be4c*/ void SetPath(int index, System.Collections.Generic.List<UnityEngine.Vector2> points);
        /*0x292bf1c*/ void SetPathList_Internal(int index, System.Collections.Generic.List<UnityEngine.Vector2> points);
        /*0x292bf70*/ void CreatePrimitive(int sides);
        /*0x292c108*/ void CreatePrimitive(int sides, UnityEngine.Vector2 scale);
        /*0x292c008*/ void CreatePrimitive(int sides, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset);
        /*0x292c178*/ void CreatePrimitive_Internal(int sides, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, bool autoRefresh);
        /*0x292c1e8*/ void CreatePrimitive_Internal_Injected(int sides, ref UnityEngine.Vector2 scale, ref UnityEngine.Vector2 offset, bool autoRefresh);
    }

    class CompositeCollider2D : UnityEngine.Collider2D
    {
        /*0x292cadc*/ CompositeCollider2D();
        /*0x292c25c*/ UnityEngine.CompositeCollider2D.GeometryType get_geometryType();
        /*0x292c298*/ void set_geometryType(UnityEngine.CompositeCollider2D.GeometryType value);
        /*0x292c2dc*/ UnityEngine.CompositeCollider2D.GenerationType get_generationType();
        /*0x292c318*/ void set_generationType(UnityEngine.CompositeCollider2D.GenerationType value);
        /*0x292c35c*/ float get_vertexDistance();
        /*0x292c398*/ void set_vertexDistance(float value);
        /*0x292c3e4*/ float get_edgeRadius();
        /*0x292c420*/ void set_edgeRadius(float value);
        /*0x292c46c*/ float get_offsetDistance();
        /*0x292c4a8*/ void set_offsetDistance(float value);
        /*0x292c4f4*/ void GenerateGeometry();
        /*0x292c530*/ int GetPathPointCount(int index);
        /*0x292c69c*/ int GetPathPointCount_Internal(int index);
        /*0x292c660*/ int get_pathCount();
        /*0x292c6e0*/ int get_pointCount();
        /*0x292c71c*/ int GetPath(int index, UnityEngine.Vector2[] points);
        /*0x292c8a8*/ int GetPathArray_Internal(int index, UnityEngine.Vector2[] points);
        /*0x292c8fc*/ int GetPath(int index, System.Collections.Generic.List<UnityEngine.Vector2> points);
        /*0x292ca88*/ int GetPathList_Internal(int index, System.Collections.Generic.List<UnityEngine.Vector2> points);

        enum GeometryType
        {
            Outlines = 0,
            Polygons = 1,
        }

        enum GenerationType
        {
            Synchronous = 0,
            Manual = 1,
        }
    }

    class Joint2D : UnityEngine.Behaviour
    {
        /*0x292cf00*/ Joint2D();
        /*0x292cae4*/ UnityEngine.Rigidbody2D get_attachedRigidbody();
        /*0x292cb20*/ UnityEngine.Rigidbody2D get_connectedBody();
        /*0x292cb5c*/ void set_connectedBody(UnityEngine.Rigidbody2D value);
        /*0x292cba0*/ bool get_enableCollision();
        /*0x292cbdc*/ void set_enableCollision(bool value);
        /*0x292cc20*/ float get_breakForce();
        /*0x292cc5c*/ void set_breakForce(float value);
        /*0x292cca8*/ float get_breakTorque();
        /*0x292cce4*/ void set_breakTorque(float value);
        /*0x292cd30*/ UnityEngine.Vector2 get_reactionForce();
        /*0x292cdc0*/ float get_reactionTorque();
        /*0x292cdfc*/ UnityEngine.Vector2 GetReactionForce(float timeStep);
        /*0x292ceb4*/ float GetReactionTorque(float timeStep);
        /*0x292cd7c*/ void get_reactionForce_Injected(ref UnityEngine.Vector2 ret);
        /*0x292ce60*/ void GetReactionForce_Injected(float timeStep, ref UnityEngine.Vector2 ret);
    }

    class AnchoredJoint2D : UnityEngine.Joint2D
    {
        /*0x292d1c0*/ AnchoredJoint2D();
        /*0x292cf08*/ UnityEngine.Vector2 get_anchor();
        /*0x292cf98*/ void set_anchor(UnityEngine.Vector2 value);
        /*0x292d024*/ UnityEngine.Vector2 get_connectedAnchor();
        /*0x292d0b4*/ void set_connectedAnchor(UnityEngine.Vector2 value);
        /*0x292d140*/ bool get_autoConfigureConnectedAnchor();
        /*0x292d17c*/ void set_autoConfigureConnectedAnchor(bool value);
        /*0x292cf54*/ void get_anchor_Injected(ref UnityEngine.Vector2 ret);
        /*0x292cfe0*/ void set_anchor_Injected(ref UnityEngine.Vector2 value);
        /*0x292d070*/ void get_connectedAnchor_Injected(ref UnityEngine.Vector2 ret);
        /*0x292d0fc*/ void set_connectedAnchor_Injected(ref UnityEngine.Vector2 value);
    }

    class SpringJoint2D : UnityEngine.AnchoredJoint2D
    {
        /*0x292d3e0*/ SpringJoint2D();
        /*0x292d1c8*/ bool get_autoConfigureDistance();
        /*0x292d204*/ void set_autoConfigureDistance(bool value);
        /*0x292d248*/ float get_distance();
        /*0x292d284*/ void set_distance(float value);
        /*0x292d2d0*/ float get_dampingRatio();
        /*0x292d30c*/ void set_dampingRatio(float value);
        /*0x292d358*/ float get_frequency();
        /*0x292d394*/ void set_frequency(float value);
    }

    class DistanceJoint2D : UnityEngine.AnchoredJoint2D
    {
        /*0x292d570*/ DistanceJoint2D();
        /*0x292d3e8*/ bool get_autoConfigureDistance();
        /*0x292d424*/ void set_autoConfigureDistance(bool value);
        /*0x292d468*/ float get_distance();
        /*0x292d4a4*/ void set_distance(float value);
        /*0x292d4f0*/ bool get_maxDistanceOnly();
        /*0x292d52c*/ void set_maxDistanceOnly(bool value);
    }

    class FrictionJoint2D : UnityEngine.AnchoredJoint2D
    {
        /*0x292d688*/ FrictionJoint2D();
        /*0x292d578*/ float get_maxForce();
        /*0x292d5b4*/ void set_maxForce(float value);
        /*0x292d600*/ float get_maxTorque();
        /*0x292d63c*/ void set_maxTorque(float value);
    }

    class HingeJoint2D : UnityEngine.AnchoredJoint2D
    {
        /*0x292db04*/ HingeJoint2D();
        /*0x292d690*/ bool get_useMotor();
        /*0x292d6cc*/ void set_useMotor(bool value);
        /*0x292d710*/ bool get_useLimits();
        /*0x292d74c*/ void set_useLimits(bool value);
        /*0x292d790*/ UnityEngine.JointMotor2D get_motor();
        /*0x292d820*/ void set_motor(UnityEngine.JointMotor2D value);
        /*0x292d8ac*/ UnityEngine.JointAngleLimits2D get_limits();
        /*0x292d93c*/ void set_limits(UnityEngine.JointAngleLimits2D value);
        /*0x292d9c8*/ UnityEngine.JointLimitState2D get_limitState();
        /*0x292da04*/ float get_referenceAngle();
        /*0x292da40*/ float get_jointAngle();
        /*0x292da7c*/ float get_jointSpeed();
        /*0x292dab8*/ float GetMotorTorque(float timeStep);
        /*0x292d7dc*/ void get_motor_Injected(ref UnityEngine.JointMotor2D ret);
        /*0x292d868*/ void set_motor_Injected(ref UnityEngine.JointMotor2D value);
        /*0x292d8f8*/ void get_limits_Injected(ref UnityEngine.JointAngleLimits2D ret);
        /*0x292d984*/ void set_limits_Injected(ref UnityEngine.JointAngleLimits2D value);
    }

    class RelativeJoint2D : UnityEngine.Joint2D
    {
        /*0x292df58*/ RelativeJoint2D();
        /*0x292db0c*/ float get_maxForce();
        /*0x292db48*/ void set_maxForce(float value);
        /*0x292db94*/ float get_maxTorque();
        /*0x292dbd0*/ void set_maxTorque(float value);
        /*0x292dc1c*/ float get_correctionScale();
        /*0x292dc58*/ void set_correctionScale(float value);
        /*0x292dca4*/ bool get_autoConfigureOffset();
        /*0x292dce0*/ void set_autoConfigureOffset(bool value);
        /*0x292dd24*/ UnityEngine.Vector2 get_linearOffset();
        /*0x292ddb4*/ void set_linearOffset(UnityEngine.Vector2 value);
        /*0x292de40*/ float get_angularOffset();
        /*0x292de7c*/ void set_angularOffset(float value);
        /*0x292dec8*/ UnityEngine.Vector2 get_target();
        /*0x292dd70*/ void get_linearOffset_Injected(ref UnityEngine.Vector2 ret);
        /*0x292ddfc*/ void set_linearOffset_Injected(ref UnityEngine.Vector2 value);
        /*0x292df14*/ void get_target_Injected(ref UnityEngine.Vector2 ret);
    }

    class SliderJoint2D : UnityEngine.AnchoredJoint2D
    {
        /*0x292e4dc*/ SliderJoint2D();
        /*0x292df60*/ bool get_autoConfigureAngle();
        /*0x292df9c*/ void set_autoConfigureAngle(bool value);
        /*0x292dfe0*/ float get_angle();
        /*0x292e01c*/ void set_angle(float value);
        /*0x292e068*/ bool get_useMotor();
        /*0x292e0a4*/ void set_useMotor(bool value);
        /*0x292e0e8*/ bool get_useLimits();
        /*0x292e124*/ void set_useLimits(bool value);
        /*0x292e168*/ UnityEngine.JointMotor2D get_motor();
        /*0x292e1f8*/ void set_motor(UnityEngine.JointMotor2D value);
        /*0x292e284*/ UnityEngine.JointTranslationLimits2D get_limits();
        /*0x292e314*/ void set_limits(UnityEngine.JointTranslationLimits2D value);
        /*0x292e3a0*/ UnityEngine.JointLimitState2D get_limitState();
        /*0x292e3dc*/ float get_referenceAngle();
        /*0x292e418*/ float get_jointTranslation();
        /*0x292e454*/ float get_jointSpeed();
        /*0x292e490*/ float GetMotorForce(float timeStep);
        /*0x292e1b4*/ void get_motor_Injected(ref UnityEngine.JointMotor2D ret);
        /*0x292e240*/ void set_motor_Injected(ref UnityEngine.JointMotor2D value);
        /*0x292e2d0*/ void get_limits_Injected(ref UnityEngine.JointTranslationLimits2D ret);
        /*0x292e35c*/ void set_limits_Injected(ref UnityEngine.JointTranslationLimits2D value);
    }

    class TargetJoint2D : UnityEngine.Joint2D
    {
        /*0x292e934*/ TargetJoint2D();
        /*0x292e4e4*/ UnityEngine.Vector2 get_anchor();
        /*0x292e574*/ void set_anchor(UnityEngine.Vector2 value);
        /*0x292e600*/ UnityEngine.Vector2 get_target();
        /*0x292e690*/ void set_target(UnityEngine.Vector2 value);
        /*0x292e71c*/ bool get_autoConfigureTarget();
        /*0x292e758*/ void set_autoConfigureTarget(bool value);
        /*0x292e79c*/ float get_maxForce();
        /*0x292e7d8*/ void set_maxForce(float value);
        /*0x292e824*/ float get_dampingRatio();
        /*0x292e860*/ void set_dampingRatio(float value);
        /*0x292e8ac*/ float get_frequency();
        /*0x292e8e8*/ void set_frequency(float value);
        /*0x292e530*/ void get_anchor_Injected(ref UnityEngine.Vector2 ret);
        /*0x292e5bc*/ void set_anchor_Injected(ref UnityEngine.Vector2 value);
        /*0x292e64c*/ void get_target_Injected(ref UnityEngine.Vector2 ret);
        /*0x292e6d8*/ void set_target_Injected(ref UnityEngine.Vector2 value);
    }

    class FixedJoint2D : UnityEngine.AnchoredJoint2D
    {
        /*0x292ea88*/ FixedJoint2D();
        /*0x292e93c*/ float get_dampingRatio();
        /*0x292e978*/ void set_dampingRatio(float value);
        /*0x292e9c4*/ float get_frequency();
        /*0x292ea00*/ void set_frequency(float value);
        /*0x292ea4c*/ float get_referenceAngle();
    }

    class WheelJoint2D : UnityEngine.AnchoredJoint2D
    {
        /*0x292eea0*/ WheelJoint2D();
        /*0x292ea90*/ UnityEngine.JointSuspension2D get_suspension();
        /*0x292eb30*/ void set_suspension(UnityEngine.JointSuspension2D value);
        /*0x292ebc8*/ bool get_useMotor();
        /*0x292ec04*/ void set_useMotor(bool value);
        /*0x292ec48*/ UnityEngine.JointMotor2D get_motor();
        /*0x292ecd8*/ void set_motor(UnityEngine.JointMotor2D value);
        /*0x292ed64*/ float get_jointTranslation();
        /*0x292eda0*/ float get_jointLinearSpeed();
        /*0x292eddc*/ float get_jointSpeed();
        /*0x292ee18*/ float get_jointAngle();
        /*0x292ee54*/ float GetMotorTorque(float timeStep);
        /*0x292eaec*/ void get_suspension_Injected(ref UnityEngine.JointSuspension2D ret);
        /*0x292eb84*/ void set_suspension_Injected(ref UnityEngine.JointSuspension2D value);
        /*0x292ec94*/ void get_motor_Injected(ref UnityEngine.JointMotor2D ret);
        /*0x292ed20*/ void set_motor_Injected(ref UnityEngine.JointMotor2D value);
    }

    class Effector2D : UnityEngine.Behaviour
    {
        /*0x292f05c*/ Effector2D();
        /*0x292eea8*/ bool get_useColliderMask();
        /*0x292eee4*/ void set_useColliderMask(bool value);
        /*0x292ef28*/ int get_colliderMask();
        /*0x292ef64*/ void set_colliderMask(int value);
        /*0x292efa8*/ bool get_requiresCollider();
        /*0x292efe4*/ bool get_designedForTrigger();
        /*0x292f020*/ bool get_designedForNonTrigger();
    }

    class AreaEffector2D : UnityEngine.Effector2D
    {
        /*0x292f40c*/ AreaEffector2D();
        /*0x292f064*/ float get_forceAngle();
        /*0x292f0a0*/ void set_forceAngle(float value);
        /*0x292f0ec*/ bool get_useGlobalAngle();
        /*0x292f128*/ void set_useGlobalAngle(bool value);
        /*0x292f16c*/ float get_forceMagnitude();
        /*0x292f1a8*/ void set_forceMagnitude(float value);
        /*0x292f1f4*/ float get_forceVariation();
        /*0x292f230*/ void set_forceVariation(float value);
        /*0x292f27c*/ float get_drag();
        /*0x292f2b8*/ void set_drag(float value);
        /*0x292f304*/ float get_angularDrag();
        /*0x292f340*/ void set_angularDrag(float value);
        /*0x292f38c*/ UnityEngine.EffectorSelection2D get_forceTarget();
        /*0x292f3c8*/ void set_forceTarget(UnityEngine.EffectorSelection2D value);
    }

    class BuoyancyEffector2D : UnityEngine.Effector2D
    {
        /*0x292f7cc*/ BuoyancyEffector2D();
        /*0x292f414*/ float get_surfaceLevel();
        /*0x292f450*/ void set_surfaceLevel(float value);
        /*0x292f49c*/ float get_density();
        /*0x292f4d8*/ void set_density(float value);
        /*0x292f524*/ float get_linearDrag();
        /*0x292f560*/ void set_linearDrag(float value);
        /*0x292f5ac*/ float get_angularDrag();
        /*0x292f5e8*/ void set_angularDrag(float value);
        /*0x292f634*/ float get_flowAngle();
        /*0x292f670*/ void set_flowAngle(float value);
        /*0x292f6bc*/ float get_flowMagnitude();
        /*0x292f6f8*/ void set_flowMagnitude(float value);
        /*0x292f744*/ float get_flowVariation();
        /*0x292f780*/ void set_flowVariation(float value);
    }

    class PointEffector2D : UnityEngine.Effector2D
    {
        /*0x292fbfc*/ PointEffector2D();
        /*0x292f7d4*/ float get_forceMagnitude();
        /*0x292f810*/ void set_forceMagnitude(float value);
        /*0x292f85c*/ float get_forceVariation();
        /*0x292f898*/ void set_forceVariation(float value);
        /*0x292f8e4*/ float get_distanceScale();
        /*0x292f920*/ void set_distanceScale(float value);
        /*0x292f96c*/ float get_drag();
        /*0x292f9a8*/ void set_drag(float value);
        /*0x292f9f4*/ float get_angularDrag();
        /*0x292fa30*/ void set_angularDrag(float value);
        /*0x292fa7c*/ UnityEngine.EffectorSelection2D get_forceSource();
        /*0x292fab8*/ void set_forceSource(UnityEngine.EffectorSelection2D value);
        /*0x292fafc*/ UnityEngine.EffectorSelection2D get_forceTarget();
        /*0x292fb38*/ void set_forceTarget(UnityEngine.EffectorSelection2D value);
        /*0x292fb7c*/ UnityEngine.EffectorForceMode2D get_forceMode();
        /*0x292fbb8*/ void set_forceMode(UnityEngine.EffectorForceMode2D value);
    }

    class PlatformEffector2D : UnityEngine.Effector2D
    {
        /*0x292ff9c*/ PlatformEffector2D();
        /*0x292fc04*/ bool get_useOneWay();
        /*0x292fc40*/ void set_useOneWay(bool value);
        /*0x292fc84*/ bool get_useOneWayGrouping();
        /*0x292fcc0*/ void set_useOneWayGrouping(bool value);
        /*0x292fd04*/ bool get_useSideFriction();
        /*0x292fd40*/ void set_useSideFriction(bool value);
        /*0x292fd84*/ bool get_useSideBounce();
        /*0x292fdc0*/ void set_useSideBounce(bool value);
        /*0x292fe04*/ float get_surfaceArc();
        /*0x292fe40*/ void set_surfaceArc(float value);
        /*0x292fe8c*/ float get_sideArc();
        /*0x292fec8*/ void set_sideArc(float value);
        /*0x292ff14*/ float get_rotationalOffset();
        /*0x292ff50*/ void set_rotationalOffset(float value);
    }

    class SurfaceEffector2D : UnityEngine.Effector2D
    {
        /*0x29302bc*/ SurfaceEffector2D();
        /*0x292ffa4*/ float get_speed();
        /*0x292ffe0*/ void set_speed(float value);
        /*0x293002c*/ float get_speedVariation();
        /*0x2930068*/ void set_speedVariation(float value);
        /*0x29300b4*/ float get_forceScale();
        /*0x29300f0*/ void set_forceScale(float value);
        /*0x293013c*/ bool get_useContactForce();
        /*0x2930178*/ void set_useContactForce(bool value);
        /*0x29301bc*/ bool get_useFriction();
        /*0x29301f8*/ void set_useFriction(bool value);
        /*0x293023c*/ bool get_useBounce();
        /*0x2930278*/ void set_useBounce(bool value);
    }

    class PhysicsUpdateBehaviour2D : UnityEngine.Behaviour
    {
        /*0x29302c4*/ PhysicsUpdateBehaviour2D();
    }

    class ConstantForce2D : UnityEngine.PhysicsUpdateBehaviour2D
    {
        /*0x293058c*/ ConstantForce2D();
        /*0x29302cc*/ UnityEngine.Vector2 get_force();
        /*0x293035c*/ void set_force(UnityEngine.Vector2 value);
        /*0x29303e8*/ UnityEngine.Vector2 get_relativeForce();
        /*0x2930478*/ void set_relativeForce(UnityEngine.Vector2 value);
        /*0x2930504*/ float get_torque();
        /*0x2930540*/ void set_torque(float value);
        /*0x2930318*/ void get_force_Injected(ref UnityEngine.Vector2 ret);
        /*0x29303a4*/ void set_force_Injected(ref UnityEngine.Vector2 value);
        /*0x2930434*/ void get_relativeForce_Injected(ref UnityEngine.Vector2 ret);
        /*0x29304c0*/ void set_relativeForce_Injected(ref UnityEngine.Vector2 value);
    }

    class PhysicsMaterial2D : UnityEngine.Object
    {
        static /*0x2930618*/ void Create_Internal(UnityEngine.PhysicsMaterial2D scriptMaterial, string name);
        /*0x2930594*/ PhysicsMaterial2D();
        /*0x293065c*/ PhysicsMaterial2D(string name);
        /*0x29306ec*/ float get_bounciness();
        /*0x2930728*/ void set_bounciness(float value);
        /*0x2930774*/ float get_friction();
        /*0x29307b0*/ void set_friction(float value);
    }
}
