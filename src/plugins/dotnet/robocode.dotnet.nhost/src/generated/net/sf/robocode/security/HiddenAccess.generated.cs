//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.robocode.security {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class HiddenAccess : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _dispatch0;
        
        internal static global::net.sf.jni4net.jni.MethodId _init1;
        
        internal static global::net.sf.jni4net.jni.MethodId _cleanup2;
        
        internal static global::net.sf.jni4net.jni.MethodId _update3;
        
        internal static global::net.sf.jni4net.jni.MethodId _isSafeThread4;
        
        internal static global::net.sf.jni4net.jni.MethodId _getSerializationType5;
        
        internal static global::net.sf.jni4net.jni.MethodId _initContainer6;
        
        internal static global::net.sf.jni4net.jni.MethodId _robocodeMain7;
        
        internal static global::net.sf.jni4net.jni.MethodId _isCriticalEvent8;
        
        internal static global::net.sf.jni4net.jni.MethodId _setEventTime9;
        
        internal static global::net.sf.jni4net.jni.MethodId _setEventPriority10;
        
        internal static global::net.sf.jni4net.jni.MethodId _setDefaultPriority11;
        
        internal static global::net.sf.jni4net.jni.MethodId _updateBullets12;
        
        internal static global::net.sf.jni4net.jni.MethodId _createSpecification13;
        
        internal static global::net.sf.jni4net.jni.MethodId _getFileSpecification14;
        
        internal static global::net.sf.jni4net.jni.MethodId _getRobotTeamName15;
        
        internal static global::net.sf.jni4net.jni.MethodId _setTeamId16;
        
        internal static global::net.sf.jni4net.jni.MethodId _createStatus17;
        
        internal static global::net.sf.jni4net.jni.MethodId _createRules18;
        
        internal static global::net.sf.jni4net.jni.MethodId _initContainerForRobotEngine19;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorHiddenAccess20;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public HiddenAccess() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.@__ctorHiddenAccess20, this);
        }
        
        protected HiddenAccess(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::net.sf.robocode.security.HiddenAccess.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.robocode.security.HiddenAccess.staticClass = @__class;
            global::net.sf.robocode.security.HiddenAccess._dispatch0 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "dispatch", "(Lrobocode/Event;Lrobocode/robotinterfaces/IBasicRobot;Lnet/sf/robocode/peer/IRob" +
                    "otStatics;Ljava/awt/Graphics2D;)V");
            global::net.sf.robocode.security.HiddenAccess._init1 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "init", "()V");
            global::net.sf.robocode.security.HiddenAccess._cleanup2 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "cleanup", "()V");
            global::net.sf.robocode.security.HiddenAccess._update3 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "update", "(Lrobocode/Bullet;DDLjava/lang/String;Z)V");
            global::net.sf.robocode.security.HiddenAccess._isSafeThread4 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "isSafeThread", "()Z");
            global::net.sf.robocode.security.HiddenAccess._getSerializationType5 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "getSerializationType", "(Lrobocode/Event;)B");
            global::net.sf.robocode.security.HiddenAccess._initContainer6 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "initContainer", "()V");
            global::net.sf.robocode.security.HiddenAccess._robocodeMain7 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "robocodeMain", "([Ljava/lang/String;)V");
            global::net.sf.robocode.security.HiddenAccess._isCriticalEvent8 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "isCriticalEvent", "(Lrobocode/Event;)Z");
            global::net.sf.robocode.security.HiddenAccess._setEventTime9 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "setEventTime", "(Lrobocode/Event;J)V");
            global::net.sf.robocode.security.HiddenAccess._setEventPriority10 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "setEventPriority", "(Lrobocode/Event;I)V");
            global::net.sf.robocode.security.HiddenAccess._setDefaultPriority11 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "setDefaultPriority", "(Lrobocode/Event;)V");
            global::net.sf.robocode.security.HiddenAccess._updateBullets12 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "updateBullets", "(Lrobocode/Event;Ljava/util/Hashtable;)V");
            global::net.sf.robocode.security.HiddenAccess._createSpecification13 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "createSpecification", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
                    "ng/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Strin" +
                    "g;)Lrobocode/control/RobotSpecification;");
            global::net.sf.robocode.security.HiddenAccess._getFileSpecification14 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "getFileSpecification", "(Lrobocode/control/RobotSpecification;)Ljava/lang/Object;");
            global::net.sf.robocode.security.HiddenAccess._getRobotTeamName15 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "getRobotTeamName", "(Lrobocode/control/RobotSpecification;)Ljava/lang/String;");
            global::net.sf.robocode.security.HiddenAccess._setTeamId16 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "setTeamId", "(Lrobocode/control/RobotSpecification;Ljava/lang/String;)V");
            global::net.sf.robocode.security.HiddenAccess._createStatus17 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "createStatus", "(DDDDDDDDDDDDIIIJ)Lrobocode/RobotStatus;");
            global::net.sf.robocode.security.HiddenAccess._createRules18 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "createRules", "(IIIDJ)Lrobocode/BattleRules;");
            global::net.sf.robocode.security.HiddenAccess._initContainerForRobotEngine19 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "initContainerForRobotEngine", "(Ljava/io/File;Lrobocode/control/events/IBattleListener;)V");
            global::net.sf.robocode.security.HiddenAccess.@__ctorHiddenAccess20 = @__env.GetMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/Event;Lrobocode/robotinterfaces/IBasicRobot;Lnet/sf/robocode/peer/IRob" +
            "otStatics;Ljava/awt/Graphics2D;)V")]
        public static void dispatch(global::java.lang.Object par0, global::java.lang.Object par1, global::net.sf.robocode.peer.IRobotStatics par2, global::java.lang.Object par3) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess._dispatch0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par1), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::net.sf.robocode.peer.IRobotStatics>(@__env, par2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par3));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public static void init() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess._init1);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public static void cleanup() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess._cleanup2);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/Bullet;DDLjava/lang/String;Z)V")]
        public static void update(global::java.lang.Object par0, double par1, double par2, global::java.lang.String par3, bool par4) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess._update3, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par4));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public static bool isSafeThread() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((bool)(@__env.CallStaticBooleanMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess._isSafeThread4)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/Event;)B")]
        public static byte getSerializationType(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((byte)(@__env.CallStaticByteMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess._getSerializationType5, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public static void initContainer() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess._initContainer6);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Ljava/lang/String;)V")]
        public static void robocodeMain(java.lang.String[] par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess._robocodeMain7, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/Event;)Z")]
        public static bool isCriticalEvent(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((bool)(@__env.CallStaticBooleanMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess._isCriticalEvent8, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/Event;J)V")]
        public static void setEventTime(global::java.lang.Object par0, long par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess._setEventTime9, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/Event;I)V")]
        public static void setEventPriority(global::java.lang.Object par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess._setEventPriority10, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/Event;)V")]
        public static void setDefaultPriority(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess._setDefaultPriority11, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/Event;Ljava/util/Hashtable;)V")]
        public static void updateBullets(global::java.lang.Object par0, global::java.util.Hashtable par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess._updateBullets12, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
            "ng/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Strin" +
            "g;)Lrobocode/control/RobotSpecification;")]
        public static global::robocode.control.RobotSpecification createSpecification(global::java.lang.Object par0, global::java.lang.String par1, global::java.lang.String par2, global::java.lang.String par3, global::java.lang.String par4, global::java.lang.String par5, global::java.lang.String par6, global::java.lang.String par7, global::java.lang.String par8) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.RobotSpecification>(@__env, @__env.CallStaticObjectMethodPtr(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess._createSpecification13, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par8)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/RobotSpecification;)Ljava/lang/Object;")]
        public static global::java.lang.Object getFileSpecification(global::robocode.control.RobotSpecification par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallStaticObjectMethodPtr(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess._getFileSpecification14, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/RobotSpecification;)Ljava/lang/String;")]
        public static global::java.lang.String getRobotTeamName(global::robocode.control.RobotSpecification par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess._getRobotTeamName15, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/RobotSpecification;Ljava/lang/String;)V")]
        public static void setTeamId(global::robocode.control.RobotSpecification par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess._setTeamId16, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(DDDDDDDDDDDDIIIJ)Lrobocode/RobotStatus;")]
        public static global::java.lang.Object createStatus(
                    double par0, 
                    double par1, 
                    double par2, 
                    double par3, 
                    double par4, 
                    double par5, 
                    double par6, 
                    double par7, 
                    double par8, 
                    double par9, 
                    double par10, 
                    double par11, 
                    int par12, 
                    int par13, 
                    int par14, 
                    long par15) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, @__env.CallStaticObjectMethodPtr(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess._createStatus17, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par10), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par11), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par12), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par13), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par14), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par15)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IIIDJ)Lrobocode/BattleRules;")]
        public static global::java.lang.Object createRules(int par0, int par1, int par2, double par3, long par4) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, @__env.CallStaticObjectMethodPtr(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess._createRules18, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par4)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/File;Lrobocode/control/events/IBattleListener;)V")]
        public static void initContainerForRobotEngine(global::java.io.File par0, global::java.lang.Object par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess._initContainerForRobotEngine19, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par1));
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.robocode.security.HiddenAccess(@__env);
            }
        }
    }
    #endregion
}
