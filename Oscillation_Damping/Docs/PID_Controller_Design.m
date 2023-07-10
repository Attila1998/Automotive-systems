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

T_I = k_v / k_r;
T_D = m / (k_r * T_I);

% sampling period
T = 0.015;

% discrete PID params
% u[k] = u[k-1] + KP*(q0*e[k] + q1*e[k-1] + q2*e[k-2])
q0 = T/T_I + T_D/T + 1
q1 = -2*T_D/T - 1
q2 = T_D / T
