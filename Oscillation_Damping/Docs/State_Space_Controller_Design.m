% the position of the potentionemters
R_m = 25000; % Mass potentiometer
R_f = 1000; % Friction (damping) potentiometer
R_r = 1000; % Spring potentiometer

% integral time constant
T_i = 0.1;

% corresponding gains
A_m = (R_m + 1000)/1000;
A_f = R_f/11000;
A_r = (R_r + 220)/1220;

% corresponding mechanical parameters
m = T_i^2 / A_m;
k_v = A_f * T_i;
k_r = A_r;

% transfer function model
num = 1/m;
den = [1 k_v/m k_r/m];
step(num, den)

% state space model 
[A, B, C, D] = tf2ss(num, den)

% sampling period
T = 0.015;

% extended state space model for integrasl control design
A_ext = [A zeros(2,1); C 0];
B_ext = [B; 0];

% LQR state feedback design 
Q = diag([1E5 1 1]);
R = 1;
[K, P, R] = lqr(A_ext, B_ext, Q, R);
K_x = K(1)
K_v = K(2)
K_I = K(3)