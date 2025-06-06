class <Module>
{
}

namespace UnityEngine
{
    class Physics
    {
        static int kIgnoreRaycastLayer = 4;
        static int kDefaultRaycastLayers = -5;
        static int kAllLayers = -1;
        static float k_MaxFloatMinusEpsilon = 3.4028232635611926e+38;
        static int IgnoreRaycastLayer = 4;
        static int DefaultRaycastLayers = -5;
        static int AllLayers = -1;
        static /*0x0*/ System.Action<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEvent;
        static /*0x8*/ System.Action<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEventCCD;

        static /*0x29317fc*/ void add_ContactModifyEvent(System.Action<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> value);
        static /*0x29318c8*/ void remove_ContactModifyEvent(System.Action<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> value);
        static /*0x2931994*/ void add_ContactModifyEventCCD(System.Action<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> value);
        static /*0x2931a64*/ void remove_ContactModifyEventCCD(System.Action<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> value);
        static /*0x2931b34*/ void OnSceneContactModify(UnityEngine.PhysicsScene scene, nint buffer, int count, bool isCCD);
        static /*0x2931c00*/ float get_minPenetrationForPenalty();
        static /*0x2931c08*/ void set_minPenetrationForPenalty(float value);
        static /*0x2931c0c*/ float get_bounceTreshold();
        static /*0x2931c5c*/ void set_bounceTreshold(float value);
        static /*0x2931ccc*/ float get_sleepVelocity();
        static /*0x2931cd4*/ void set_sleepVelocity(float value);
        static /*0x2931cd8*/ float get_sleepAngularVelocity();
        static /*0x2931ce0*/ void set_sleepAngularVelocity(float value);
        static /*0x2931ce4*/ float get_maxAngularVelocity();
        static /*0x2931cec*/ void set_maxAngularVelocity(float value);
        static /*0x2931cf0*/ int get_solverIterationCount();
        static /*0x2931d40*/ void set_solverIterationCount(int value);
        static /*0x2931db8*/ int get_solverVelocityIterationCount();
        static /*0x2931e08*/ void set_solverVelocityIterationCount(int value);
        static /*0x2931e80*/ float get_penetrationPenaltyForce();
        static /*0x2931e88*/ void set_penetrationPenaltyForce(float value);
        static /*0x2931e8c*/ UnityEngine.Vector3 get_gravity();
        static /*0x2931f14*/ void set_gravity(UnityEngine.Vector3 value);
        static /*0x2931f94*/ float get_defaultContactOffset();
        static /*0x2931fbc*/ void set_defaultContactOffset(float value);
        static /*0x2931ff4*/ float get_sleepThreshold();
        static /*0x293201c*/ void set_sleepThreshold(float value);
        static /*0x2932054*/ bool get_queriesHitTriggers();
        static /*0x293207c*/ void set_queriesHitTriggers(bool value);
        static /*0x29320b8*/ bool get_queriesHitBackfaces();
        static /*0x29320e0*/ void set_queriesHitBackfaces(bool value);
        static /*0x2931c34*/ float get_bounceThreshold();
        static /*0x2931c94*/ void set_bounceThreshold(float value);
        static /*0x293211c*/ float get_defaultMaxDepenetrationVelocity();
        static /*0x2932144*/ void set_defaultMaxDepenetrationVelocity(float value);
        static /*0x2931d18*/ int get_defaultSolverIterations();
        static /*0x2931d7c*/ void set_defaultSolverIterations(int value);
        static /*0x2931de0*/ int get_defaultSolverVelocityIterations();
        static /*0x2931e44*/ void set_defaultSolverVelocityIterations(int value);
        static /*0x293217c*/ float get_defaultMaxAngularSpeed();
        static /*0x29321a4*/ void set_defaultMaxAngularSpeed(float value);
        static /*0x29321dc*/ bool get_improvedPatchFriction();
        static /*0x2932204*/ void set_improvedPatchFriction(bool value);
        static /*0x2932240*/ UnityEngine.PhysicsScene get_defaultPhysicsScene();
        static /*0x29322c0*/ void IgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2, bool ignore);
        static /*0x2932314*/ void IgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2);
        static /*0x293235c*/ void IgnoreLayerCollision(int layer1, int layer2, bool ignore);
        static /*0x29323b0*/ void IgnoreLayerCollision(int layer1, int layer2);
        static /*0x29323f8*/ bool GetIgnoreLayerCollision(int layer1, int layer2);
        static /*0x293243c*/ bool GetIgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2);
        static /*0x2932480*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x293269c*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask);
        static /*0x2932760*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance);
        static /*0x2932818*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);
        static /*0x29328c8*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2932b08*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask);
        static /*0x2932bd4*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance);
        static /*0x2932c9c*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo);
        static /*0x2932d5c*/ bool Raycast(UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2932e2c*/ bool Raycast(UnityEngine.Ray ray, float maxDistance, int layerMask);
        static /*0x2932ef0*/ bool Raycast(UnityEngine.Ray ray, float maxDistance);
        static /*0x2932fb0*/ bool Raycast(UnityEngine.Ray ray);
        static /*0x2933070*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2933148*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask);
        static /*0x29331c4*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance);
        static /*0x293328c*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo);
        static /*0x2933354*/ bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2933468*/ bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, int layerMask);
        static /*0x2933470*/ bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end);
        static /*0x293347c*/ bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, ref UnityEngine.RaycastHit hitInfo, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29335a0*/ bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, ref UnityEngine.RaycastHit hitInfo, int layerMask);
        static /*0x29335a8*/ bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, ref UnityEngine.RaycastHit hitInfo);
        static /*0x29335b4*/ bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29336b0*/ bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float maxDistance, int layerMask);
        static /*0x29336d0*/ bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float maxDistance);
        static /*0x29336f4*/ bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction);
        static /*0x2933730*/ bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x293380c*/ bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask);
        static /*0x293382c*/ bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance);
        static /*0x2933850*/ bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo);
        static /*0x293388c*/ bool SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2933960*/ bool SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask);
        static /*0x2933968*/ bool SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance);
        static /*0x2933974*/ bool SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo);
        static /*0x2933988*/ bool SphereCast(UnityEngine.Ray ray, float radius, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2933a30*/ bool SphereCast(UnityEngine.Ray ray, float radius, float maxDistance, int layerMask);
        static /*0x2933a64*/ bool SphereCast(UnityEngine.Ray ray, float radius, float maxDistance);
        static /*0x2933a9c*/ bool SphereCast(UnityEngine.Ray ray, float radius);
        static /*0x2933adc*/ bool SphereCast(UnityEngine.Ray ray, float radius, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2933b74*/ bool SphereCast(UnityEngine.Ray ray, float radius, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask);
        static /*0x2933ba8*/ bool SphereCast(UnityEngine.Ray ray, float radius, ref UnityEngine.RaycastHit hitInfo, float maxDistance);
        static /*0x2933be0*/ bool SphereCast(UnityEngine.Ray ray, float radius, ref UnityEngine.RaycastHit hitInfo);
        static /*0x2933c20*/ bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2933d24*/ bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance, int layerMask);
        static /*0x2933d4c*/ bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance);
        static /*0x2933d78*/ bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation);
        static /*0x2933dbc*/ bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction);
        static /*0x2933e90*/ bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, UnityEngine.Quaternion orientation, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2933f6c*/ bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, UnityEngine.Quaternion orientation, float maxDistance, int layerMask);
        static /*0x2933f94*/ bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, UnityEngine.Quaternion orientation, float maxDistance);
        static /*0x2933fc0*/ bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, UnityEngine.Quaternion orientation);
        static /*0x2934004*/ bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo);
        static /*0x29340e8*/ UnityEngine.RaycastHit[] Internal_RaycastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29341cc*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x293436c*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask);
        static /*0x2934374*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance);
        static /*0x2934380*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);
        static /*0x2934394*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x293440c*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance, int layerMask);
        static /*0x2934480*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance);
        static /*0x29344e8*/ UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray);
        static /*0x2934550*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2934800*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask);
        static /*0x29348d0*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance);
        static /*0x2934994*/ int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results);
        static /*0x2934a58*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2934b2c*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask);
        static /*0x2934bf4*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance);
        static /*0x2934cb8*/ int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results);
        static /*0x2934d74*/ UnityEngine.RaycastHit[] Query_CapsuleCastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, float radius, UnityEngine.Vector3 direction, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2934e9c*/ UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2935028*/ UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float maxDistance, int layerMask);
        static /*0x2935048*/ UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float maxDistance);
        static /*0x293506c*/ UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction);
        static /*0x29350a4*/ UnityEngine.RaycastHit[] Query_SphereCastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29351b0*/ UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x293532c*/ UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, float maxDistance, int layerMask);
        static /*0x2935334*/ UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, float maxDistance);
        static /*0x2935340*/ UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction);
        static /*0x2935354*/ UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, float radius, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29353dc*/ UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, float radius, float maxDistance, int layerMask);
        static /*0x293540c*/ UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, float radius, float maxDistance);
        static /*0x2935440*/ UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, float radius);
        static /*0x293547c*/ UnityEngine.Collider[] OverlapCapsule_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2935578*/ UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2935628*/ UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, int layerMask);
        static /*0x2935630*/ UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius);
        static /*0x293563c*/ UnityEngine.Collider[] OverlapSphere_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x293571c*/ UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29357ac*/ UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, float radius, int layerMask);
        static /*0x29357b4*/ UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, float radius);
        static /*0x29357c0*/ void Simulate_Internal(UnityEngine.PhysicsScene physicsScene, float step);
        static /*0x2935854*/ void Simulate(float step);
        static /*0x2935960*/ bool get_autoSimulation();
        static /*0x2935988*/ void set_autoSimulation(bool value);
        static /*0x29359c4*/ void SyncTransforms();
        static /*0x29359ec*/ bool get_autoSyncTransforms();
        static /*0x2935a14*/ void set_autoSyncTransforms(bool value);
        static /*0x2935a50*/ bool get_reuseCollisionCallbacks();
        static /*0x2935a78*/ void set_reuseCollisionCallbacks(bool value);
        static /*0x2935ab4*/ bool Query_ComputePenetration(UnityEngine.Collider colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, ref UnityEngine.Vector3 direction, ref float distance);
        static /*0x2935be4*/ bool ComputePenetration(UnityEngine.Collider colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, ref UnityEngine.Vector3 direction, ref float distance);
        static /*0x2935ccc*/ UnityEngine.Vector3 Query_ClosestPoint(UnityEngine.Collider collider, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 point);
        static /*0x2935dc0*/ UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 point, UnityEngine.Collider collider, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x2935df0*/ float get_interCollisionDistance();
        static /*0x2935e18*/ void set_interCollisionDistance(float value);
        static /*0x2935e50*/ float get_interCollisionStiffness();
        static /*0x2935e78*/ void set_interCollisionStiffness(float value);
        static /*0x2935eb0*/ bool get_interCollisionSettingsToggle();
        static /*0x2935ed8*/ void set_interCollisionSettingsToggle(bool value);
        static /*0x2935f14*/ UnityEngine.Vector3 get_clothGravity();
        static /*0x2935f9c*/ void set_clothGravity(UnityEngine.Vector3 value);
        static /*0x293601c*/ int OverlapSphereNonAlloc(UnityEngine.Vector3 position, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29360bc*/ int OverlapSphereNonAlloc(UnityEngine.Vector3 position, float radius, UnityEngine.Collider[] results, int layerMask);
        static /*0x29360c4*/ int OverlapSphereNonAlloc(UnityEngine.Vector3 position, float radius, UnityEngine.Collider[] results);
        static /*0x29360d0*/ bool CheckSphere_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29361b4*/ bool CheckSphere(UnityEngine.Vector3 position, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2936248*/ bool CheckSphere(UnityEngine.Vector3 position, float radius, int layerMask);
        static /*0x2936250*/ bool CheckSphere(UnityEngine.Vector3 position, float radius);
        static /*0x293625c*/ int CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2936474*/ int CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask);
        static /*0x2936494*/ int CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance);
        static /*0x29364b8*/ int CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results);
        static /*0x29364f0*/ int SphereCastNonAlloc(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29366ec*/ int SphereCastNonAlloc(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask);
        static /*0x29366f4*/ int SphereCastNonAlloc(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance);
        static /*0x2936700*/ int SphereCastNonAlloc(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results);
        static /*0x2936714*/ int SphereCastNonAlloc(UnityEngine.Ray ray, float radius, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29367ac*/ int SphereCastNonAlloc(UnityEngine.Ray ray, float radius, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask);
        static /*0x29367dc*/ int SphereCastNonAlloc(UnityEngine.Ray ray, float radius, UnityEngine.RaycastHit[] results, float maxDistance);
        static /*0x2936810*/ int SphereCastNonAlloc(UnityEngine.Ray ray, float radius, UnityEngine.RaycastHit[] results);
        static /*0x293684c*/ bool CheckCapsule_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 start, UnityEngine.Vector3 end, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x293694c*/ bool CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2936a00*/ bool CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float radius, int layerMask);
        static /*0x2936a08*/ bool CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float radius);
        static /*0x2936a14*/ bool CheckBox_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, int layermask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2936b08*/ bool CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, int layermask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2936bc4*/ bool CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, int layerMask);
        static /*0x2936bd4*/ bool CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation);
        static /*0x2936be8*/ bool CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents);
        static /*0x2936c9c*/ UnityEngine.Collider[] OverlapBox_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2936d8c*/ UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2936e44*/ UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, int layerMask);
        static /*0x2936e54*/ UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation);
        static /*0x2936e68*/ UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents);
        static /*0x2936f18*/ int OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2937004*/ int OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, int mask);
        static /*0x2937014*/ int OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation);
        static /*0x2937028*/ int OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results);
        static /*0x29370e8*/ int BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29372f8*/ int BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation);
        static /*0x2937338*/ int BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, float maxDistance);
        static /*0x2937364*/ int BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, float maxDistance, int layerMask);
        static /*0x293738c*/ int BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results);
        static /*0x293746c*/ UnityEngine.RaycastHit[] Internal_BoxCastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29375a0*/ UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2937768*/ UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance, int layerMask);
        static /*0x2937790*/ UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance);
        static /*0x29377bc*/ UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation);
        static /*0x29377fc*/ UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction);
        static /*0x29378cc*/ int OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x293799c*/ int OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, UnityEngine.Collider[] results, int layerMask);
        static /*0x29379a4*/ int OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, UnityEngine.Collider[] results);
        static /*0x29379b0*/ void Internal_RebuildBroadphaseRegions(UnityEngine.Bounds bounds, int subdivisions);
        static /*0x2937a38*/ void RebuildBroadphaseRegions(UnityEngine.Bounds worldBounds, int subdivisions);
        static /*0x2937b4c*/ void BakeMesh(int meshID, bool convex);
        static /*0x2931ed8*/ void get_gravity_Injected(ref UnityEngine.Vector3 ret);
        static /*0x2931f58*/ void set_gravity_Injected(ref UnityEngine.Vector3 value);
        static /*0x2932284*/ void get_defaultPhysicsScene_Injected(ref UnityEngine.PhysicsScene ret);
        static /*0x2934160*/ UnityEngine.RaycastHit[] Internal_RaycastAll_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2934e10*/ UnityEngine.RaycastHit[] Query_CapsuleCastAll_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 p0, ref UnityEngine.Vector3 p1, float radius, ref UnityEngine.Vector3 direction, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x293512c*/ UnityEngine.RaycastHit[] Query_SphereCastAll_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 origin, float radius, ref UnityEngine.Vector3 direction, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29354fc*/ UnityEngine.Collider[] OverlapCapsule_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 point0, ref UnityEngine.Vector3 point1, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29356b0*/ UnityEngine.Collider[] OverlapSphere_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 position, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2935808*/ void Simulate_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, float step);
        static /*0x2935b58*/ bool Query_ComputePenetration_Injected(UnityEngine.Collider colliderA, ref UnityEngine.Vector3 positionA, ref UnityEngine.Quaternion rotationA, UnityEngine.Collider colliderB, ref UnityEngine.Vector3 positionB, ref UnityEngine.Quaternion rotationB, ref UnityEngine.Vector3 direction, ref float distance);
        static /*0x2935d54*/ void Query_ClosestPoint_Injected(UnityEngine.Collider collider, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.Vector3 point, ref UnityEngine.Vector3 ret);
        static /*0x2935f60*/ void get_clothGravity_Injected(ref UnityEngine.Vector3 ret);
        static /*0x2935fe0*/ void set_clothGravity_Injected(ref UnityEngine.Vector3 value);
        static /*0x2936148*/ bool CheckSphere_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 position, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29368d0*/ bool CheckCapsule_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 start, ref UnityEngine.Vector3 end, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2936a94*/ bool CheckBox_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 halfExtents, ref UnityEngine.Quaternion orientation, int layermask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2936d18*/ UnityEngine.Collider[] OverlapBox_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 halfExtents, ref UnityEngine.Quaternion orientation, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x293750c*/ UnityEngine.RaycastHit[] Internal_BoxCastAll_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 halfExtents, ref UnityEngine.Vector3 direction, ref UnityEngine.Quaternion orientation, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29379f4*/ void Internal_RebuildBroadphaseRegions_Injected(ref UnityEngine.Bounds bounds, int subdivisions);
        /*0x2937b90*/ Physics();
    }

    struct ModifiableContactPair
    {
        /*0x10*/ nint actor;
        /*0x18*/ nint otherActor;
        /*0x20*/ nint shape;
        /*0x28*/ nint otherShape;
        /*0x30*/ UnityEngine.Quaternion rotation;
        /*0x40*/ UnityEngine.Vector3 position;
        /*0x4c*/ UnityEngine.Quaternion otherRotation;
        /*0x5c*/ UnityEngine.Vector3 otherPosition;
        /*0x68*/ int numContacts;
        /*0x70*/ nint contacts;
    }

    class ArticulationBody : UnityEngine.Behaviour
    {
        /*0x2937b98*/ ArticulationBody();
    }

    class PhysicMaterial : UnityEngine.Object
    {
        static /*0x2937c3c*/ void Internal_CreateDynamicsMaterial(UnityEngine.PhysicMaterial mat, string name);
        /*0x2937ba0*/ PhysicMaterial();
    }

    struct RaycastHit
    {
        /*0x10*/ UnityEngine.Vector3 m_Point;
        /*0x1c*/ UnityEngine.Vector3 m_Normal;
        /*0x28*/ uint m_FaceID;
        /*0x2c*/ float m_Distance;
        /*0x30*/ UnityEngine.Vector2 m_UV;
        /*0x38*/ int m_Collider;

        static /*0x2937dc4*/ UnityEngine.Vector2 CalculateRaycastTexCoord(UnityEngine.Collider collider, UnityEngine.Vector2 uv, UnityEngine.Vector3 pos, uint face, int textcoord);
        static /*0x2937e44*/ void CalculateRaycastTexCoord_Injected(UnityEngine.Collider collider, ref UnityEngine.Vector2 uv, ref UnityEngine.Vector3 pos, uint face, int textcoord, ref UnityEngine.Vector2 ret);
        /*0x2937c80*/ UnityEngine.Vector2 get_textureCoord1();
        /*0x2937cac*/ UnityEngine.Collider get_collider();
        /*0x2937d58*/ int get_colliderInstanceID();
        /*0x2937d60*/ UnityEngine.Vector3 get_point();
        /*0x2937d6c*/ void set_point(UnityEngine.Vector3 value);
        /*0x2937d78*/ UnityEngine.Vector3 get_normal();
        /*0x2937d84*/ void set_normal(UnityEngine.Vector3 value);
        /*0x2937d90*/ UnityEngine.Vector3 get_barycentricCoordinate();
        /*0x2937da4*/ void set_barycentricCoordinate(UnityEngine.Vector3 value);
        /*0x2937dac*/ float get_distance();
        /*0x2937db4*/ void set_distance(float value);
        /*0x2937dbc*/ int get_triangleIndex();
        /*0x2937eb8*/ UnityEngine.Vector2 get_textureCoord();
        /*0x2937c84*/ UnityEngine.Vector2 get_textureCoord2();
        /*0x2937ee0*/ UnityEngine.Transform get_transform();
        /*0x2937fbc*/ UnityEngine.Rigidbody get_rigidbody();
        /*0x29380b4*/ UnityEngine.ArticulationBody get_articulationBody();
        /*0x29381ac*/ UnityEngine.Vector2 get_lightmapCoord();
    }

    class Rigidbody : UnityEngine.Component
    {
        /*0x29385b0*/ Rigidbody();
        /*0x29382ac*/ UnityEngine.Vector3 get_position();
        /*0x293834c*/ UnityEngine.Quaternion get_rotation();
        /*0x29383e8*/ void set_rotation(UnityEngine.Quaternion value);
        /*0x2938480*/ void MovePosition(UnityEngine.Vector3 position);
        /*0x2938518*/ void MoveRotation(UnityEngine.Quaternion rot);
        /*0x2938308*/ void get_position_Injected(ref UnityEngine.Vector3 ret);
        /*0x29383a4*/ void get_rotation_Injected(ref UnityEngine.Quaternion ret);
        /*0x293843c*/ void set_rotation_Injected(ref UnityEngine.Quaternion value);
        /*0x29384d4*/ void MovePosition_Injected(ref UnityEngine.Vector3 position);
        /*0x293856c*/ void MoveRotation_Injected(ref UnityEngine.Quaternion rot);
    }

    class MeshCollider : UnityEngine.Collider
    {
    }

    class BoxCollider : UnityEngine.Collider
    {
    }

    class Collision
    {
        /*0x10*/ UnityEngine.Vector3 m_Impulse;
        /*0x1c*/ UnityEngine.Vector3 m_RelativeVelocity;
        /*0x28*/ UnityEngine.Component m_Body;
        /*0x30*/ UnityEngine.Collider m_Collider;
        /*0x38*/ int m_ContactCount;
        /*0x40*/ UnityEngine.ContactPoint[] m_ReusedContacts;
        /*0x48*/ UnityEngine.ContactPoint[] m_LegacyContacts;
    }

    class Collider : UnityEngine.Component
    {
        /*0x2938d40*/ Collider();
        /*0x29385b8*/ bool get_enabled();
        /*0x29385f4*/ void set_enabled(bool value);
        /*0x2938078*/ UnityEngine.Rigidbody get_attachedRigidbody();
        /*0x2938170*/ UnityEngine.ArticulationBody get_attachedArticulationBody();
        /*0x2938638*/ bool get_isTrigger();
        /*0x2938674*/ void set_isTrigger(bool value);
        /*0x29386b8*/ float get_contactOffset();
        /*0x29386f4*/ void set_contactOffset(float value);
        /*0x2938740*/ UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 position);
        /*0x29387fc*/ UnityEngine.Bounds get_bounds();
        /*0x29388a8*/ bool get_hasModifiableContacts();
        /*0x29388e4*/ void set_hasModifiableContacts(bool value);
        /*0x2938928*/ UnityEngine.PhysicMaterial get_sharedMaterial();
        /*0x2938964*/ void set_sharedMaterial(UnityEngine.PhysicMaterial value);
        /*0x29389a8*/ UnityEngine.PhysicMaterial get_material();
        /*0x29389e4*/ void set_material(UnityEngine.PhysicMaterial value);
        /*0x2938a28*/ UnityEngine.RaycastHit Raycast(UnityEngine.Ray ray, float maxDistance, ref bool hasHit);
        /*0x2938b28*/ bool Raycast(UnityEngine.Ray ray, ref UnityEngine.RaycastHit hitInfo, float maxDistance);
        /*0x2938bd4*/ void Internal_ClosestPointOnBounds(UnityEngine.Vector3 point, ref UnityEngine.Vector3 outPos, ref float distance);
        /*0x2938c9c*/ UnityEngine.Vector3 ClosestPointOnBounds(UnityEngine.Vector3 position);
        /*0x29387a8*/ void ClosestPoint_Injected(ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        /*0x2938864*/ void get_bounds_Injected(ref UnityEngine.Bounds ret);
        /*0x2938abc*/ void Raycast_Injected(ref UnityEngine.Ray ray, float maxDistance, ref bool hasHit, ref UnityEngine.RaycastHit ret);
        /*0x2938c40*/ void Internal_ClosestPointOnBounds_Injected(ref UnityEngine.Vector3 point, ref UnityEngine.Vector3 outPos, ref float distance);
    }

    class CharacterController : UnityEngine.Collider
    {
    }

    class CapsuleCollider : UnityEngine.Collider
    {
    }

    class SphereCollider : UnityEngine.Collider
    {
    }

    struct ContactPoint
    {
        /*0x10*/ UnityEngine.Vector3 m_Point;
        /*0x1c*/ UnityEngine.Vector3 m_Normal;
        /*0x28*/ int m_ThisColliderInstanceID;
        /*0x2c*/ int m_OtherColliderInstanceID;
        /*0x30*/ float m_Separation;
    }

    struct PhysicsScene : System.IEquatable<UnityEngine.PhysicsScene>
    {
        /*0x10*/ int m_Handle;

        static /*0x2938ebc*/ bool Internal_RaycastTest(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2938fa4*/ bool Internal_Raycast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, ref UnityEngine.RaycastHit hit, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x293909c*/ int Internal_RaycastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2939190*/ bool Query_CapsuleCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float maxDistance, ref UnityEngine.RaycastHit hitInfo, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29392dc*/ bool Internal_CapsuleCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2939428*/ int Internal_CapsuleCastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2939570*/ int OverlapCapsuleNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2939684*/ bool Query_SphereCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, float maxDistance, ref UnityEngine.RaycastHit hitInfo, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29397ac*/ bool Internal_SphereCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29398d8*/ int Internal_SphereCastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29399fc*/ int OverlapSphereNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2939afc*/ bool Query_BoxCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance, ref UnityEngine.RaycastHit outHit, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2939c4c*/ bool Internal_BoxCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2939d90*/ int OverlapBoxNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2939ea0*/ int Internal_BoxCastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, UnityEngine.Quaternion orientation, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2938f38*/ bool Internal_RaycastTest_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2939020*/ bool Internal_Raycast_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, ref UnityEngine.RaycastHit hit, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2939114*/ int Internal_RaycastNonAlloc_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2939240*/ bool Query_CapsuleCast_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 point1, ref UnityEngine.Vector3 point2, float radius, ref UnityEngine.Vector3 direction, float maxDistance, ref UnityEngine.RaycastHit hitInfo, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x29394d4*/ int Internal_CapsuleCastNonAlloc_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 p0, ref UnityEngine.Vector3 p1, float radius, ref UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2939600*/ int OverlapCapsuleNonAlloc_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 point0, ref UnityEngine.Vector3 point1, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2939720*/ bool Query_SphereCast_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 origin, float radius, ref UnityEngine.Vector3 direction, float maxDistance, ref UnityEngine.RaycastHit hitInfo, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2939970*/ int Internal_SphereCastNonAlloc_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 origin, float radius, ref UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2939a80*/ int OverlapSphereNonAlloc_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 position, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2939bb0*/ bool Query_BoxCast_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 halfExtents, ref UnityEngine.Vector3 direction, ref UnityEngine.Quaternion orientation, float maxDistance, ref UnityEngine.RaycastHit outHit, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2939e1c*/ int OverlapBoxNonAlloc_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, ref UnityEngine.Quaternion orientation, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        static /*0x2939f50*/ int Internal_BoxCastNonAlloc_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 halfExtents, ref UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, ref UnityEngine.Quaternion orientation, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x2938d48*/ string ToString();
        /*0x2938e2c*/ int GetHashCode();
        /*0x2938e34*/ bool Equals(object other);
        /*0x2938eac*/ bool Equals(UnityEngine.PhysicsScene other);
        /*0x2932548*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x29329a0*/ bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x2934624*/ int Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x2933690*/ bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x2936340*/ int CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x2937994*/ int OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x2933958*/ bool SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x29365cc*/ int SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x29360b4*/ int OverlapSphere(UnityEngine.Vector3 position, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x2933cf4*/ bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, ref UnityEngine.RaycastHit hitInfo, UnityEngine.Quaternion orientation, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x2936fe8*/ int OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
        /*0x29371cc*/ int BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction);
    }

    class ControllerColliderHit
    {
        /*0x10*/ UnityEngine.CharacterController m_Controller;
        /*0x18*/ UnityEngine.Collider m_Collider;
        /*0x20*/ UnityEngine.Vector3 m_Point;
        /*0x2c*/ UnityEngine.Vector3 m_Normal;
        /*0x38*/ UnityEngine.Vector3 m_MoveDirection;
        /*0x44*/ float m_MoveLength;
        /*0x48*/ int m_Push;
    }

    enum QueryTriggerInteraction
    {
        UseGlobal = 0,
        Ignore = 1,
        Collide = 2,
    }
}
