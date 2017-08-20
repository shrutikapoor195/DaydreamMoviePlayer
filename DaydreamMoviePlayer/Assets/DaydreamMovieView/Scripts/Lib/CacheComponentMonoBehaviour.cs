using UnityEngine;
using UnityEngine.Experimental.Director;
using UnityEngine.Networking.Match;

public class CacheComponentMonoBehaviour : MonoBehaviour
{
	private Behaviour m_Behaviour;

	public Behaviour cachedBehaviour {
		get {
			if (m_Behaviour == null)
				m_Behaviour = GetComponent<Behaviour> ();
			return m_Behaviour;
		}
	}

	private BillboardRenderer m_BillboardRenderer;

	public BillboardRenderer cachedBillboardRenderer {
		get {
			if (m_BillboardRenderer == null)
				m_BillboardRenderer = GetComponent<BillboardRenderer> ();
			return m_BillboardRenderer;
		}
	}

	private Camera m_Camera;

	public Camera cachedCamera {
		get {
			if (m_Camera == null)
				m_Camera = GetComponent<Camera> ();
			return m_Camera;
		}
	}

	private FlareLayer m_FlareLayer;

	public FlareLayer cachedFlareLayer {
		get {
			if (m_FlareLayer == null)
				m_FlareLayer = GetComponent<FlareLayer> ();
			return m_FlareLayer;
		}
	}

	private OcclusionArea m_OcclusionArea;

	public OcclusionArea cachedOcclusionArea {
		get {
			if (m_OcclusionArea == null)
				m_OcclusionArea = GetComponent<OcclusionArea> ();
			return m_OcclusionArea;
		}
	}

	private OcclusionPortal m_OcclusionPortal;

	public OcclusionPortal cachedOcclusionPortal {
		get {
			if (m_OcclusionPortal == null)
				m_OcclusionPortal = GetComponent<OcclusionPortal> ();
			return m_OcclusionPortal;
		}
	}

	private MeshFilter m_MeshFilter;

	public MeshFilter cachedMeshFilter {
		get {
			if (m_MeshFilter == null)
				m_MeshFilter = GetComponent<MeshFilter> ();
			return m_MeshFilter;
		}
	}

	private SkinnedMeshRenderer m_SkinnedMeshRenderer;

	public SkinnedMeshRenderer cachedSkinnedMeshRenderer {
		get {
			if (m_SkinnedMeshRenderer == null)
				m_SkinnedMeshRenderer = GetComponent<SkinnedMeshRenderer> ();
			return m_SkinnedMeshRenderer;
		}
	}

	private LensFlare m_LensFlare;

	public LensFlare cachedLensFlare {
		get {
			if (m_LensFlare == null)
				m_LensFlare = GetComponent<LensFlare> ();
			return m_LensFlare;
		}
	}

	private Renderer m_Renderer;

	public Renderer cachedRenderer {
		get {
			if (m_Renderer == null)
				m_Renderer = GetComponent<Renderer> ();
			return m_Renderer;
		}
	}

	private Projector m_Projector;

	public Projector cachedProjector {
		get {
			if (m_Projector == null)
				m_Projector = GetComponent<Projector> ();
			return m_Projector;
		}
	}

	private Skybox m_Skybox;

	public Skybox cachedSkybox {
		get {
			if (m_Skybox == null)
				m_Skybox = GetComponent<Skybox> ();
			return m_Skybox;
		}
	}

	private TrailRenderer m_TrailRenderer;

	public TrailRenderer cachedTrailRenderer {
		get {
			if (m_TrailRenderer == null)
				m_TrailRenderer = GetComponent<TrailRenderer> ();
			return m_TrailRenderer;
		}
	}

	private LineRenderer m_LineRenderer;

	public LineRenderer cachedLineRenderer {
		get {
			if (m_LineRenderer == null)
				m_LineRenderer = GetComponent<LineRenderer> ();
			return m_LineRenderer;
		}
	}

	private MeshRenderer m_MeshRenderer;

	public MeshRenderer cachedMeshRenderer {
		get {
			if (m_MeshRenderer == null)
				m_MeshRenderer = GetComponent<MeshRenderer> ();
			return m_MeshRenderer;
		}
	}

	private GUIElement m_GUIElement;

	public GUIElement cachedGUIElement {
		get {
			if (m_GUIElement == null)
				m_GUIElement = GetComponent<GUIElement> ();
			return m_GUIElement;
		}
	}

	private GUITexture m_GUITexture;

	public GUITexture cachedGUITexture {
		get {
			if (m_GUITexture == null)
				m_GUITexture = GetComponent<GUITexture> ();
			return m_GUITexture;
		}
	}

	private GUILayer m_GUILayer;

	public GUILayer cachedGUILayer {
		get {
			if (m_GUILayer == null)
				m_GUILayer = GetComponent<GUILayer> ();
			return m_GUILayer;
		}
	}

	private Light m_Light;

	public Light cachedLight {
		get {
			if (m_Light == null)
				m_Light = GetComponent<Light> ();
			return m_Light;
		}
	}

	private LightProbeGroup m_LightProbeGroup;

	public LightProbeGroup cachedLightProbeGroup {
		get {
			if (m_LightProbeGroup == null)
				m_LightProbeGroup = GetComponent<LightProbeGroup> ();
			return m_LightProbeGroup;
		}
	}

	private LightProbeProxyVolume m_LightProbeProxyVolume;

	public LightProbeProxyVolume cachedLightProbeProxyVolume {
		get {
			if (m_LightProbeProxyVolume == null)
				m_LightProbeProxyVolume = GetComponent<LightProbeProxyVolume> ();
			return m_LightProbeProxyVolume;
		}
	}

	private LODGroup m_LODGroup;

	public LODGroup cachedLODGroup {
		get {
			if (m_LODGroup == null)
				m_LODGroup = GetComponent<LODGroup> ();
			return m_LODGroup;
		}
	}

	private ReflectionProbe m_ReflectionProbe;

	public ReflectionProbe cachedReflectionProbe {
		get {
			if (m_ReflectionProbe == null)
				m_ReflectionProbe = GetComponent<ReflectionProbe> ();
			return m_ReflectionProbe;
		}
	}

	private SpriteRenderer m_SpriteRenderer;

	public SpriteRenderer cachedSpriteRenderer {
		get {
			if (m_SpriteRenderer == null)
				m_SpriteRenderer = GetComponent<SpriteRenderer> ();
			return m_SpriteRenderer;
		}
	}

	private WindZone m_WindZone;

	public WindZone cachedWindZone {
		get {
			if (m_WindZone == null)
				m_WindZone = GetComponent<WindZone> ();
			return m_WindZone;
		}
	}

	private Transform m_Transform;

	public Transform cachedTransform {
		get {
			if (m_Transform == null)
				m_Transform = GetComponent<Transform> ();
			return m_Transform;
		}
	}

	private RectTransform m_RectTransform;

	public RectTransform cachedRectTransform {
		get {
			if (m_RectTransform == null)
				m_RectTransform = GetComponent<RectTransform> ();
			return m_RectTransform;
		}
	}

	private SortingGroup m_SortingGroup;

	public SortingGroup cachedSortingGroup {
		get {
			if (m_SortingGroup == null)
				m_SortingGroup = GetComponent<SortingGroup> ();
			return m_SortingGroup;
		}
	}

	private ParticleSystem m_ParticleSystem;

	public ParticleSystem cachedParticleSystem {
		get {
			if (m_ParticleSystem == null)
				m_ParticleSystem = GetComponent<ParticleSystem> ();
			return m_ParticleSystem;
		}
	}

	private ParticleSystemRenderer m_ParticleSystemRenderer;

	public ParticleSystemRenderer cachedParticleSystemRenderer {
		get {
			if (m_ParticleSystemRenderer == null)
				m_ParticleSystemRenderer = GetComponent<ParticleSystemRenderer> ();
			return m_ParticleSystemRenderer;
		}
	}

	private Rigidbody m_Rigidbody;

	public Rigidbody cachedRigidbody {
		get {
			if (m_Rigidbody == null)
				m_Rigidbody = GetComponent<Rigidbody> ();
			return m_Rigidbody;
		}
	}

	private Joint m_Joint;

	public Joint cachedJoint {
		get {
			if (m_Joint == null)
				m_Joint = GetComponent<Joint> ();
			return m_Joint;
		}
	}

	private HingeJoint m_HingeJoint;

	public HingeJoint cachedHingeJoint {
		get {
			if (m_HingeJoint == null)
				m_HingeJoint = GetComponent<HingeJoint> ();
			return m_HingeJoint;
		}
	}

	private SpringJoint m_SpringJoint;

	public SpringJoint cachedSpringJoint {
		get {
			if (m_SpringJoint == null)
				m_SpringJoint = GetComponent<SpringJoint> ();
			return m_SpringJoint;
		}
	}

	private FixedJoint m_FixedJoint;

	public FixedJoint cachedFixedJoint {
		get {
			if (m_FixedJoint == null)
				m_FixedJoint = GetComponent<FixedJoint> ();
			return m_FixedJoint;
		}
	}

	private CharacterJoint m_CharacterJoint;

	public CharacterJoint cachedCharacterJoint {
		get {
			if (m_CharacterJoint == null)
				m_CharacterJoint = GetComponent<CharacterJoint> ();
			return m_CharacterJoint;
		}
	}

	private ConfigurableJoint m_ConfigurableJoint;

	public ConfigurableJoint cachedConfigurableJoint {
		get {
			if (m_ConfigurableJoint == null)
				m_ConfigurableJoint = GetComponent<ConfigurableJoint> ();
			return m_ConfigurableJoint;
		}
	}

	private ConstantForce m_ConstantForce;

	public ConstantForce cachedConstantForce {
		get {
			if (m_ConstantForce == null)
				m_ConstantForce = GetComponent<ConstantForce> ();
			return m_ConstantForce;
		}
	}

	private Collider m_Collider;

	public Collider cachedCollider {
		get {
			if (m_Collider == null)
				m_Collider = GetComponent<Collider> ();
			return m_Collider;
		}
	}

	private BoxCollider m_BoxCollider;

	public BoxCollider cachedBoxCollider {
		get {
			if (m_BoxCollider == null)
				m_BoxCollider = GetComponent<BoxCollider> ();
			return m_BoxCollider;
		}
	}

	private SphereCollider m_SphereCollider;

	public SphereCollider cachedSphereCollider {
		get {
			if (m_SphereCollider == null)
				m_SphereCollider = GetComponent<SphereCollider> ();
			return m_SphereCollider;
		}
	}

	private MeshCollider m_MeshCollider;

	public MeshCollider cachedMeshCollider {
		get {
			if (m_MeshCollider == null)
				m_MeshCollider = GetComponent<MeshCollider> ();
			return m_MeshCollider;
		}
	}

	private CapsuleCollider m_CapsuleCollider;

	public CapsuleCollider cachedCapsuleCollider {
		get {
			if (m_CapsuleCollider == null)
				m_CapsuleCollider = GetComponent<CapsuleCollider> ();
			return m_CapsuleCollider;
		}
	}

	private CharacterController m_CharacterController;

	public CharacterController cachedCharacterController {
		get {
			if (m_CharacterController == null)
				m_CharacterController = GetComponent<CharacterController> ();
			return m_CharacterController;
		}
	}

	private CircleCollider2D m_CircleCollider2D;

	public CircleCollider2D cachedCircleCollider2D {
		get {
			if (m_CircleCollider2D == null)
				m_CircleCollider2D = GetComponent<CircleCollider2D> ();
			return m_CircleCollider2D;
		}
	}

	private BoxCollider2D m_BoxCollider2D;

	public BoxCollider2D cachedBoxCollider2D {
		get {
			if (m_BoxCollider2D == null)
				m_BoxCollider2D = GetComponent<BoxCollider2D> ();
			return m_BoxCollider2D;
		}
	}

	private Joint2D m_Joint2D;

	public Joint2D cachedJoint2D {
		get {
			if (m_Joint2D == null)
				m_Joint2D = GetComponent<Joint2D> ();
			return m_Joint2D;
		}
	}

	private AreaEffector2D m_AreaEffector2D;

	public AreaEffector2D cachedAreaEffector2D {
		get {
			if (m_AreaEffector2D == null)
				m_AreaEffector2D = GetComponent<AreaEffector2D> ();
			return m_AreaEffector2D;
		}
	}

	private PlatformEffector2D m_PlatformEffector2D;

	public PlatformEffector2D cachedPlatformEffector2D {
		get {
			if (m_PlatformEffector2D == null)
				m_PlatformEffector2D = GetComponent<PlatformEffector2D> ();
			return m_PlatformEffector2D;
		}
	}

	private Rigidbody2D m_Rigidbody2D;

	public Rigidbody2D cachedRigidbody2D {
		get {
			if (m_Rigidbody2D == null)
				m_Rigidbody2D = GetComponent<Rigidbody2D> ();
			return m_Rigidbody2D;
		}
	}

	private Collider2D m_Collider2D;

	public Collider2D cachedCollider2D {
		get {
			if (m_Collider2D == null)
				m_Collider2D = GetComponent<Collider2D> ();
			return m_Collider2D;
		}
	}

	private EdgeCollider2D m_EdgeCollider2D;

	public EdgeCollider2D cachedEdgeCollider2D {
		get {
			if (m_EdgeCollider2D == null)
				m_EdgeCollider2D = GetComponent<EdgeCollider2D> ();
			return m_EdgeCollider2D;
		}
	}

	private CapsuleCollider2D m_CapsuleCollider2D;

	public CapsuleCollider2D cachedCapsuleCollider2D {
		get {
			if (m_CapsuleCollider2D == null)
				m_CapsuleCollider2D = GetComponent<CapsuleCollider2D> ();
			return m_CapsuleCollider2D;
		}
	}

	private CompositeCollider2D m_CompositeCollider2D;

	public CompositeCollider2D cachedCompositeCollider2D {
		get {
			if (m_CompositeCollider2D == null)
				m_CompositeCollider2D = GetComponent<CompositeCollider2D> ();
			return m_CompositeCollider2D;
		}
	}

	private PolygonCollider2D m_PolygonCollider2D;

	public PolygonCollider2D cachedPolygonCollider2D {
		get {
			if (m_PolygonCollider2D == null)
				m_PolygonCollider2D = GetComponent<PolygonCollider2D> ();
			return m_PolygonCollider2D;
		}
	}

	private AnchoredJoint2D m_AnchoredJoint2D;

	public AnchoredJoint2D cachedAnchoredJoint2D {
		get {
			if (m_AnchoredJoint2D == null)
				m_AnchoredJoint2D = GetComponent<AnchoredJoint2D> ();
			return m_AnchoredJoint2D;
		}
	}

	private SpringJoint2D m_SpringJoint2D;

	public SpringJoint2D cachedSpringJoint2D {
		get {
			if (m_SpringJoint2D == null)
				m_SpringJoint2D = GetComponent<SpringJoint2D> ();
			return m_SpringJoint2D;
		}
	}

	private DistanceJoint2D m_DistanceJoint2D;

	public DistanceJoint2D cachedDistanceJoint2D {
		get {
			if (m_DistanceJoint2D == null)
				m_DistanceJoint2D = GetComponent<DistanceJoint2D> ();
			return m_DistanceJoint2D;
		}
	}

	private FrictionJoint2D m_FrictionJoint2D;

	public FrictionJoint2D cachedFrictionJoint2D {
		get {
			if (m_FrictionJoint2D == null)
				m_FrictionJoint2D = GetComponent<FrictionJoint2D> ();
			return m_FrictionJoint2D;
		}
	}

	private HingeJoint2D m_HingeJoint2D;

	public HingeJoint2D cachedHingeJoint2D {
		get {
			if (m_HingeJoint2D == null)
				m_HingeJoint2D = GetComponent<HingeJoint2D> ();
			return m_HingeJoint2D;
		}
	}

	private RelativeJoint2D m_RelativeJoint2D;

	public RelativeJoint2D cachedRelativeJoint2D {
		get {
			if (m_RelativeJoint2D == null)
				m_RelativeJoint2D = GetComponent<RelativeJoint2D> ();
			return m_RelativeJoint2D;
		}
	}

	private SliderJoint2D m_SliderJoint2D;

	public SliderJoint2D cachedSliderJoint2D {
		get {
			if (m_SliderJoint2D == null)
				m_SliderJoint2D = GetComponent<SliderJoint2D> ();
			return m_SliderJoint2D;
		}
	}

	private TargetJoint2D m_TargetJoint2D;

	public TargetJoint2D cachedTargetJoint2D {
		get {
			if (m_TargetJoint2D == null)
				m_TargetJoint2D = GetComponent<TargetJoint2D> ();
			return m_TargetJoint2D;
		}
	}

	private FixedJoint2D m_FixedJoint2D;

	public FixedJoint2D cachedFixedJoint2D {
		get {
			if (m_FixedJoint2D == null)
				m_FixedJoint2D = GetComponent<FixedJoint2D> ();
			return m_FixedJoint2D;
		}
	}

	private WheelJoint2D m_WheelJoint2D;

	public WheelJoint2D cachedWheelJoint2D {
		get {
			if (m_WheelJoint2D == null)
				m_WheelJoint2D = GetComponent<WheelJoint2D> ();
			return m_WheelJoint2D;
		}
	}

	private PhysicsUpdateBehaviour2D m_PhysicsUpdateBehaviour2D;

	public PhysicsUpdateBehaviour2D cachedPhysicsUpdateBehaviour2D {
		get {
			if (m_PhysicsUpdateBehaviour2D == null)
				m_PhysicsUpdateBehaviour2D = GetComponent<PhysicsUpdateBehaviour2D> ();
			return m_PhysicsUpdateBehaviour2D;
		}
	}

	private ConstantForce2D m_ConstantForce2D;

	public ConstantForce2D cachedConstantForce2D {
		get {
			if (m_ConstantForce2D == null)
				m_ConstantForce2D = GetComponent<ConstantForce2D> ();
			return m_ConstantForce2D;
		}
	}

	private Effector2D m_Effector2D;

	public Effector2D cachedEffector2D {
		get {
			if (m_Effector2D == null)
				m_Effector2D = GetComponent<Effector2D> ();
			return m_Effector2D;
		}
	}

	private BuoyancyEffector2D m_BuoyancyEffector2D;

	public BuoyancyEffector2D cachedBuoyancyEffector2D {
		get {
			if (m_BuoyancyEffector2D == null)
				m_BuoyancyEffector2D = GetComponent<BuoyancyEffector2D> ();
			return m_BuoyancyEffector2D;
		}
	}

	private PointEffector2D m_PointEffector2D;

	public PointEffector2D cachedPointEffector2D {
		get {
			if (m_PointEffector2D == null)
				m_PointEffector2D = GetComponent<PointEffector2D> ();
			return m_PointEffector2D;
		}
	}

	private SurfaceEffector2D m_SurfaceEffector2D;

	public SurfaceEffector2D cachedSurfaceEffector2D {
		get {
			if (m_SurfaceEffector2D == null)
				m_SurfaceEffector2D = GetComponent<SurfaceEffector2D> ();
			return m_SurfaceEffector2D;
		}
	}

	private WheelCollider m_WheelCollider;

	public WheelCollider cachedWheelCollider {
		get {
			if (m_WheelCollider == null)
				m_WheelCollider = GetComponent<WheelCollider> ();
			return m_WheelCollider;
		}
	}

	private Cloth m_Cloth;

	public Cloth cachedCloth {
		get {
			if (m_Cloth == null)
				m_Cloth = GetComponent<Cloth> ();
			return m_Cloth;
		}
	}

	private UnityEngine.AI.NavMeshAgent m_NavMeshAgent;

	public UnityEngine.AI.NavMeshAgent cachedNavMeshAgent {
		get {
			if (m_NavMeshAgent == null)
				m_NavMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
			return m_NavMeshAgent;
		}
	}

	private UnityEngine.AI.NavMeshObstacle m_NavMeshObstacle;

	public UnityEngine.AI.NavMeshObstacle cachedNavMeshObstacle {
		get {
			if (m_NavMeshObstacle == null)
				m_NavMeshObstacle = GetComponent<UnityEngine.AI.NavMeshObstacle> ();
			return m_NavMeshObstacle;
		}
	}

	private UnityEngine.AI.OffMeshLink m_OffMeshLink;

	public UnityEngine.AI.OffMeshLink cachedOffMeshLink {
		get {
			if (m_OffMeshLink == null)
				m_OffMeshLink = GetComponent<UnityEngine.AI.OffMeshLink> ();
			return m_OffMeshLink;
		}
	}

	private AudioSource m_AudioSource;

	public AudioSource cachedAudioSource {
		get {
			if (m_AudioSource == null)
				m_AudioSource = GetComponent<AudioSource> ();
			return m_AudioSource;
		}
	}

	private AudioLowPassFilter m_AudioLowPassFilter;

	public AudioLowPassFilter cachedAudioLowPassFilter {
		get {
			if (m_AudioLowPassFilter == null)
				m_AudioLowPassFilter = GetComponent<AudioLowPassFilter> ();
			return m_AudioLowPassFilter;
		}
	}

	private AudioHighPassFilter m_AudioHighPassFilter;

	public AudioHighPassFilter cachedAudioHighPassFilter {
		get {
			if (m_AudioHighPassFilter == null)
				m_AudioHighPassFilter = GetComponent<AudioHighPassFilter> ();
			return m_AudioHighPassFilter;
		}
	}

	private AudioReverbFilter m_AudioReverbFilter;

	public AudioReverbFilter cachedAudioReverbFilter {
		get {
			if (m_AudioReverbFilter == null)
				m_AudioReverbFilter = GetComponent<AudioReverbFilter> ();
			return m_AudioReverbFilter;
		}
	}

	private AudioBehaviour m_AudioBehaviour;

	public AudioBehaviour cachedAudioBehaviour {
		get {
			if (m_AudioBehaviour == null)
				m_AudioBehaviour = GetComponent<AudioBehaviour> ();
			return m_AudioBehaviour;
		}
	}

	private AudioListener m_AudioListener;

	public AudioListener cachedAudioListener {
		get {
			if (m_AudioListener == null)
				m_AudioListener = GetComponent<AudioListener> ();
			return m_AudioListener;
		}
	}

	private AudioReverbZone m_AudioReverbZone;

	public AudioReverbZone cachedAudioReverbZone {
		get {
			if (m_AudioReverbZone == null)
				m_AudioReverbZone = GetComponent<AudioReverbZone> ();
			return m_AudioReverbZone;
		}
	}

	private AudioDistortionFilter m_AudioDistortionFilter;

	public AudioDistortionFilter cachedAudioDistortionFilter {
		get {
			if (m_AudioDistortionFilter == null)
				m_AudioDistortionFilter = GetComponent<AudioDistortionFilter> ();
			return m_AudioDistortionFilter;
		}
	}

	private AudioEchoFilter m_AudioEchoFilter;

	public AudioEchoFilter cachedAudioEchoFilter {
		get {
			if (m_AudioEchoFilter == null)
				m_AudioEchoFilter = GetComponent<AudioEchoFilter> ();
			return m_AudioEchoFilter;
		}
	}

	private AudioChorusFilter m_AudioChorusFilter;

	public AudioChorusFilter cachedAudioChorusFilter {
		get {
			if (m_AudioChorusFilter == null)
				m_AudioChorusFilter = GetComponent<AudioChorusFilter> ();
			return m_AudioChorusFilter;
		}
	}

	private Animator m_Animator;

	public Animator cachedAnimator {
		get {
			if (m_Animator == null)
				m_Animator = GetComponent<Animator> ();
			return m_Animator;
		}
	}

	private Animation m_Animation;

	public Animation cachedAnimation {
		get {
			if (m_Animation == null)
				m_Animation = GetComponent<Animation> ();
			return m_Animation;
		}
	}

	private Terrain m_Terrain;

	public Terrain cachedTerrain {
		get {
			if (m_Terrain == null)
				m_Terrain = GetComponent<Terrain> ();
			return m_Terrain;
		}
	}

	private Tree m_Tree;

	public Tree cachedTree {
		get {
			if (m_Tree == null)
				m_Tree = GetComponent<Tree> ();
			return m_Tree;
		}
	}

	private GUIText m_GUIText;

	public GUIText cachedGUIText {
		get {
			if (m_GUIText == null)
				m_GUIText = GetComponent<GUIText> ();
			return m_GUIText;
		}
	}

	private TextMesh m_TextMesh;

	public TextMesh cachedTextMesh {
		get {
			if (m_TextMesh == null)
				m_TextMesh = GetComponent<TextMesh> ();
			return m_TextMesh;
		}
	}

	private Canvas m_Canvas;

	public Canvas cachedCanvas {
		get {
			if (m_Canvas == null)
				m_Canvas = GetComponent<Canvas> ();
			return m_Canvas;
		}
	}

	private CanvasGroup m_CanvasGroup;

	public CanvasGroup cachedCanvasGroup {
		get {
			if (m_CanvasGroup == null)
				m_CanvasGroup = GetComponent<CanvasGroup> ();
			return m_CanvasGroup;
		}
	}

	private CanvasRenderer m_CanvasRenderer;

	public CanvasRenderer cachedCanvasRenderer {
		get {
			if (m_CanvasRenderer == null)
				m_CanvasRenderer = GetComponent<CanvasRenderer> ();
			return m_CanvasRenderer;
		}
	}

	private TerrainCollider m_TerrainCollider;

	public TerrainCollider cachedTerrainCollider {
		get {
			if (m_TerrainCollider == null)
				m_TerrainCollider = GetComponent<TerrainCollider> ();
			return m_TerrainCollider;
		}
	}

	private NetworkMatch m_NetworkMatch;

	public NetworkMatch cachedNetworkMatch {
		get {
			if (m_NetworkMatch == null)
				m_NetworkMatch = GetComponent<NetworkMatch> ();
			return m_NetworkMatch;
		}
	}

	private PlayableDirector m_PlayableDirector;

	public PlayableDirector cachedPlayableDirector {
		get {
			if (m_PlayableDirector == null)
				m_PlayableDirector = GetComponent<PlayableDirector> ();
			return m_PlayableDirector;
		}
	}

	private WorldAnchor m_WorldAnchor;

	public WorldAnchor cachedWorldAnchor {
		get {
			if (m_WorldAnchor == null)
				m_WorldAnchor = GetComponent<WorldAnchor> ();
			return m_WorldAnchor;
		}
	}

	private VideoPlayer m_VideoPlayer;

	public VideoPlayer cachedVideoPlayer {
		get {
			if (m_VideoPlayer == null)
				m_VideoPlayer = GetComponent<VideoPlayer> ();
			return m_VideoPlayer;
		}
	}

	private SpriteMask m_SpriteMask;

	public SpriteMask cachedSpriteMask {
		get {
			if (m_SpriteMask == null)
				m_SpriteMask = GetComponent<SpriteMask> ();
			return m_SpriteMask;
		}
	}

}