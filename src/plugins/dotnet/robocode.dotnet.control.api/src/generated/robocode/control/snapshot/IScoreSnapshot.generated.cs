//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace robocode.control.snapshot {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface IScoreSnapshot : global::java.lang.Comparable {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String getName();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()D")]
        double getTotalScore();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()D")]
        double getTotalSurvivalScore();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()D")]
        double getTotalLastSurvivorBonus();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()D")]
        double getTotalBulletDamageScore();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()D")]
        double getTotalBulletKillBonus();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()D")]
        double getTotalRammingDamageScore();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()D")]
        double getTotalRammingKillBonus();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int getTotalFirsts();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int getTotalSeconds();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int getTotalThirds();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()D")]
        double getCurrentScore();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()D")]
        double getCurrentSurvivalScore();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()D")]
        double getCurrentSurvivalBonus();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()D")]
        double getCurrentBulletDamageScore();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()D")]
        double getCurrentBulletKillBonus();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()D")]
        double getCurrentRammingDamageScore();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()D")]
        double getCurrentRammingKillBonus();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class IScoreSnapshot_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::robocode.control.snapshot.@__IScoreSnapshot.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::robocode.control.snapshot.IScoreSnapshot), typeof(global::robocode.control.snapshot.IScoreSnapshot_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::robocode.control.snapshot.IScoreSnapshot), typeof(global::robocode.control.snapshot.IScoreSnapshot_))]
    internal sealed partial class @__IScoreSnapshot : global::java.lang.Object, global::robocode.control.snapshot.IScoreSnapshot {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getName1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getTotalScore2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getTotalSurvivalScore3;
        
        internal static global::net.sf.jni4net.jni.MethodId _getTotalLastSurvivorBonus4;
        
        internal static global::net.sf.jni4net.jni.MethodId _getTotalBulletDamageScore5;
        
        internal static global::net.sf.jni4net.jni.MethodId _getTotalBulletKillBonus6;
        
        internal static global::net.sf.jni4net.jni.MethodId _getTotalRammingDamageScore7;
        
        internal static global::net.sf.jni4net.jni.MethodId _getTotalRammingKillBonus8;
        
        internal static global::net.sf.jni4net.jni.MethodId _getTotalFirsts9;
        
        internal static global::net.sf.jni4net.jni.MethodId _getTotalSeconds10;
        
        internal static global::net.sf.jni4net.jni.MethodId _getTotalThirds11;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCurrentScore12;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCurrentSurvivalScore13;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCurrentSurvivalBonus14;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCurrentBulletDamageScore15;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCurrentBulletKillBonus16;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCurrentRammingDamageScore17;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCurrentRammingKillBonus18;
        
        private @__IScoreSnapshot(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::robocode.control.snapshot.@__IScoreSnapshot.staticClass = @__class;
            global::robocode.control.snapshot.@__IScoreSnapshot._compareTo0 = @__env.GetMethodID(global::robocode.control.snapshot.@__IScoreSnapshot.staticClass, "compareTo", "(Ljava/lang/Object;)I");
            global::robocode.control.snapshot.@__IScoreSnapshot._getName1 = @__env.GetMethodID(global::robocode.control.snapshot.@__IScoreSnapshot.staticClass, "getName", "()Ljava/lang/String;");
            global::robocode.control.snapshot.@__IScoreSnapshot._getTotalScore2 = @__env.GetMethodID(global::robocode.control.snapshot.@__IScoreSnapshot.staticClass, "getTotalScore", "()D");
            global::robocode.control.snapshot.@__IScoreSnapshot._getTotalSurvivalScore3 = @__env.GetMethodID(global::robocode.control.snapshot.@__IScoreSnapshot.staticClass, "getTotalSurvivalScore", "()D");
            global::robocode.control.snapshot.@__IScoreSnapshot._getTotalLastSurvivorBonus4 = @__env.GetMethodID(global::robocode.control.snapshot.@__IScoreSnapshot.staticClass, "getTotalLastSurvivorBonus", "()D");
            global::robocode.control.snapshot.@__IScoreSnapshot._getTotalBulletDamageScore5 = @__env.GetMethodID(global::robocode.control.snapshot.@__IScoreSnapshot.staticClass, "getTotalBulletDamageScore", "()D");
            global::robocode.control.snapshot.@__IScoreSnapshot._getTotalBulletKillBonus6 = @__env.GetMethodID(global::robocode.control.snapshot.@__IScoreSnapshot.staticClass, "getTotalBulletKillBonus", "()D");
            global::robocode.control.snapshot.@__IScoreSnapshot._getTotalRammingDamageScore7 = @__env.GetMethodID(global::robocode.control.snapshot.@__IScoreSnapshot.staticClass, "getTotalRammingDamageScore", "()D");
            global::robocode.control.snapshot.@__IScoreSnapshot._getTotalRammingKillBonus8 = @__env.GetMethodID(global::robocode.control.snapshot.@__IScoreSnapshot.staticClass, "getTotalRammingKillBonus", "()D");
            global::robocode.control.snapshot.@__IScoreSnapshot._getTotalFirsts9 = @__env.GetMethodID(global::robocode.control.snapshot.@__IScoreSnapshot.staticClass, "getTotalFirsts", "()I");
            global::robocode.control.snapshot.@__IScoreSnapshot._getTotalSeconds10 = @__env.GetMethodID(global::robocode.control.snapshot.@__IScoreSnapshot.staticClass, "getTotalSeconds", "()I");
            global::robocode.control.snapshot.@__IScoreSnapshot._getTotalThirds11 = @__env.GetMethodID(global::robocode.control.snapshot.@__IScoreSnapshot.staticClass, "getTotalThirds", "()I");
            global::robocode.control.snapshot.@__IScoreSnapshot._getCurrentScore12 = @__env.GetMethodID(global::robocode.control.snapshot.@__IScoreSnapshot.staticClass, "getCurrentScore", "()D");
            global::robocode.control.snapshot.@__IScoreSnapshot._getCurrentSurvivalScore13 = @__env.GetMethodID(global::robocode.control.snapshot.@__IScoreSnapshot.staticClass, "getCurrentSurvivalScore", "()D");
            global::robocode.control.snapshot.@__IScoreSnapshot._getCurrentSurvivalBonus14 = @__env.GetMethodID(global::robocode.control.snapshot.@__IScoreSnapshot.staticClass, "getCurrentSurvivalBonus", "()D");
            global::robocode.control.snapshot.@__IScoreSnapshot._getCurrentBulletDamageScore15 = @__env.GetMethodID(global::robocode.control.snapshot.@__IScoreSnapshot.staticClass, "getCurrentBulletDamageScore", "()D");
            global::robocode.control.snapshot.@__IScoreSnapshot._getCurrentBulletKillBonus16 = @__env.GetMethodID(global::robocode.control.snapshot.@__IScoreSnapshot.staticClass, "getCurrentBulletKillBonus", "()D");
            global::robocode.control.snapshot.@__IScoreSnapshot._getCurrentRammingDamageScore17 = @__env.GetMethodID(global::robocode.control.snapshot.@__IScoreSnapshot.staticClass, "getCurrentRammingDamageScore", "()D");
            global::robocode.control.snapshot.@__IScoreSnapshot._getCurrentRammingKillBonus18 = @__env.GetMethodID(global::robocode.control.snapshot.@__IScoreSnapshot.staticClass, "getCurrentRammingKillBonus", "()D");
        }
        
        public int compareTo(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::robocode.control.snapshot.@__IScoreSnapshot._compareTo0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        public global::java.lang.String getName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.snapshot.@__IScoreSnapshot._getName1));
        }
        
        public double getTotalScore() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((double)(@__env.CallDoubleMethod(this, global::robocode.control.snapshot.@__IScoreSnapshot._getTotalScore2)));
        }
        
        public double getTotalSurvivalScore() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((double)(@__env.CallDoubleMethod(this, global::robocode.control.snapshot.@__IScoreSnapshot._getTotalSurvivalScore3)));
        }
        
        public double getTotalLastSurvivorBonus() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((double)(@__env.CallDoubleMethod(this, global::robocode.control.snapshot.@__IScoreSnapshot._getTotalLastSurvivorBonus4)));
        }
        
        public double getTotalBulletDamageScore() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((double)(@__env.CallDoubleMethod(this, global::robocode.control.snapshot.@__IScoreSnapshot._getTotalBulletDamageScore5)));
        }
        
        public double getTotalBulletKillBonus() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((double)(@__env.CallDoubleMethod(this, global::robocode.control.snapshot.@__IScoreSnapshot._getTotalBulletKillBonus6)));
        }
        
        public double getTotalRammingDamageScore() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((double)(@__env.CallDoubleMethod(this, global::robocode.control.snapshot.@__IScoreSnapshot._getTotalRammingDamageScore7)));
        }
        
        public double getTotalRammingKillBonus() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((double)(@__env.CallDoubleMethod(this, global::robocode.control.snapshot.@__IScoreSnapshot._getTotalRammingKillBonus8)));
        }
        
        public int getTotalFirsts() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::robocode.control.snapshot.@__IScoreSnapshot._getTotalFirsts9)));
        }
        
        public int getTotalSeconds() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::robocode.control.snapshot.@__IScoreSnapshot._getTotalSeconds10)));
        }
        
        public int getTotalThirds() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::robocode.control.snapshot.@__IScoreSnapshot._getTotalThirds11)));
        }
        
        public double getCurrentScore() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((double)(@__env.CallDoubleMethod(this, global::robocode.control.snapshot.@__IScoreSnapshot._getCurrentScore12)));
        }
        
        public double getCurrentSurvivalScore() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((double)(@__env.CallDoubleMethod(this, global::robocode.control.snapshot.@__IScoreSnapshot._getCurrentSurvivalScore13)));
        }
        
        public double getCurrentSurvivalBonus() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((double)(@__env.CallDoubleMethod(this, global::robocode.control.snapshot.@__IScoreSnapshot._getCurrentSurvivalBonus14)));
        }
        
        public double getCurrentBulletDamageScore() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((double)(@__env.CallDoubleMethod(this, global::robocode.control.snapshot.@__IScoreSnapshot._getCurrentBulletDamageScore15)));
        }
        
        public double getCurrentBulletKillBonus() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((double)(@__env.CallDoubleMethod(this, global::robocode.control.snapshot.@__IScoreSnapshot._getCurrentBulletKillBonus16)));
        }
        
        public double getCurrentRammingDamageScore() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((double)(@__env.CallDoubleMethod(this, global::robocode.control.snapshot.@__IScoreSnapshot._getCurrentRammingDamageScore17)));
        }
        
        public double getCurrentRammingKillBonus() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((double)(@__env.CallDoubleMethod(this, global::robocode.control.snapshot.@__IScoreSnapshot._getCurrentRammingKillBonus18)));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IScoreSnapshot);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "compareTo", "compareTo0", "(Lrobocode/control/snapshot/IScoreSnapshot;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getName", "getName1", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getTotalScore", "getTotalScore2", "()D"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getTotalSurvivalScore", "getTotalSurvivalScore3", "()D"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getTotalLastSurvivorBonus", "getTotalLastSurvivorBonus4", "()D"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getTotalBulletDamageScore", "getTotalBulletDamageScore5", "()D"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getTotalBulletKillBonus", "getTotalBulletKillBonus6", "()D"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getTotalRammingDamageScore", "getTotalRammingDamageScore7", "()D"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getTotalRammingKillBonus", "getTotalRammingKillBonus8", "()D"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getTotalFirsts", "getTotalFirsts9", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getTotalSeconds", "getTotalSeconds10", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getTotalThirds", "getTotalThirds11", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getCurrentScore", "getCurrentScore12", "()D"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getCurrentSurvivalScore", "getCurrentSurvivalScore13", "()D"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getCurrentSurvivalBonus", "getCurrentSurvivalBonus14", "()D"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getCurrentBulletDamageScore", "getCurrentBulletDamageScore15", "()D"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getCurrentBulletKillBonus", "getCurrentBulletKillBonus16", "()D"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getCurrentRammingDamageScore", "getCurrentRammingDamageScore17", "()D"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getCurrentRammingKillBonus", "getCurrentRammingKillBonus18", "()D"));
            return methods;
        }
        
        private static int compareTo0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/Object;)I
            // (Ljava/lang/Object;)I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::robocode.control.snapshot.IScoreSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__obj);
            @__return = ((int)(((global::java.lang.Comparable)(@__real)).compareTo(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, par0))));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getName1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::robocode.control.snapshot.IScoreSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getName());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static double getTotalScore2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()D
            // ()D
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            double @__return = default(double);
            try {
            global::robocode.control.snapshot.IScoreSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__obj);
            @__return = ((double)(@__real.getTotalScore()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static double getTotalSurvivalScore3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()D
            // ()D
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            double @__return = default(double);
            try {
            global::robocode.control.snapshot.IScoreSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__obj);
            @__return = ((double)(@__real.getTotalSurvivalScore()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static double getTotalLastSurvivorBonus4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()D
            // ()D
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            double @__return = default(double);
            try {
            global::robocode.control.snapshot.IScoreSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__obj);
            @__return = ((double)(@__real.getTotalLastSurvivorBonus()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static double getTotalBulletDamageScore5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()D
            // ()D
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            double @__return = default(double);
            try {
            global::robocode.control.snapshot.IScoreSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__obj);
            @__return = ((double)(@__real.getTotalBulletDamageScore()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static double getTotalBulletKillBonus6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()D
            // ()D
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            double @__return = default(double);
            try {
            global::robocode.control.snapshot.IScoreSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__obj);
            @__return = ((double)(@__real.getTotalBulletKillBonus()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static double getTotalRammingDamageScore7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()D
            // ()D
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            double @__return = default(double);
            try {
            global::robocode.control.snapshot.IScoreSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__obj);
            @__return = ((double)(@__real.getTotalRammingDamageScore()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static double getTotalRammingKillBonus8(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()D
            // ()D
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            double @__return = default(double);
            try {
            global::robocode.control.snapshot.IScoreSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__obj);
            @__return = ((double)(@__real.getTotalRammingKillBonus()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int getTotalFirsts9(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::robocode.control.snapshot.IScoreSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__obj);
            @__return = ((int)(@__real.getTotalFirsts()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int getTotalSeconds10(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::robocode.control.snapshot.IScoreSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__obj);
            @__return = ((int)(@__real.getTotalSeconds()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int getTotalThirds11(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::robocode.control.snapshot.IScoreSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__obj);
            @__return = ((int)(@__real.getTotalThirds()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static double getCurrentScore12(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()D
            // ()D
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            double @__return = default(double);
            try {
            global::robocode.control.snapshot.IScoreSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__obj);
            @__return = ((double)(@__real.getCurrentScore()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static double getCurrentSurvivalScore13(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()D
            // ()D
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            double @__return = default(double);
            try {
            global::robocode.control.snapshot.IScoreSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__obj);
            @__return = ((double)(@__real.getCurrentSurvivalScore()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static double getCurrentSurvivalBonus14(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()D
            // ()D
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            double @__return = default(double);
            try {
            global::robocode.control.snapshot.IScoreSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__obj);
            @__return = ((double)(@__real.getCurrentSurvivalBonus()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static double getCurrentBulletDamageScore15(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()D
            // ()D
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            double @__return = default(double);
            try {
            global::robocode.control.snapshot.IScoreSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__obj);
            @__return = ((double)(@__real.getCurrentBulletDamageScore()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static double getCurrentBulletKillBonus16(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()D
            // ()D
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            double @__return = default(double);
            try {
            global::robocode.control.snapshot.IScoreSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__obj);
            @__return = ((double)(@__real.getCurrentBulletKillBonus()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static double getCurrentRammingDamageScore17(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()D
            // ()D
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            double @__return = default(double);
            try {
            global::robocode.control.snapshot.IScoreSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__obj);
            @__return = ((double)(@__real.getCurrentRammingDamageScore()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static double getCurrentRammingKillBonus18(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()D
            // ()D
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            double @__return = default(double);
            try {
            global::robocode.control.snapshot.IScoreSnapshot @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IScoreSnapshot>(@__env, @__obj);
            @__return = ((double)(@__real.getCurrentRammingKillBonus()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::robocode.control.snapshot.@__IScoreSnapshot(@__env);
            }
        }
    }
    #endregion
}
