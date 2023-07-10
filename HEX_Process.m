function  [sys, x0] = HEX_Process(t,x,u,flag, process_parameters)

switch flag
  case 0                                                % Initialization
    sys = [2,      % number of continuous states
           0,      % number of discrete states
           2,      % number of outputs
           2,      % number of inputs
           0,      % reserved must be zero
           0];     % direct feedthrough flag
    x0  = [0 0];

  case 1                                                % Continuous_derivates
     
    T_h  = x(1);   % Hot outlet temperature
    T_c  = x(2);   % Cold outlet temperature
    
    v_h = u(1);    % Hot flow rate (Control)
    T_c_I = u(2);  % Cold inlet temperature (Load disturbance)
    
    V_h = process_parameters(1);  % Hot reservoir volume
    ro_h = process_parameters(2); % Hot fluid density
    c_h = process_parameters(3);  % Hot fluid specific heat
    
    T_h_I = process_parameters(4);
    
    v_c = process_parameters(5);  % Cold flow rate
    V_c = process_parameters(6);  % Cold reservoir volume
    ro_c = process_parameters(7); % Cold fluid density
    c_c = process_parameters(8);  % Cold fluid specific heat
    
    S = process_parameters(9);   % Heat transfer area
    K = process_parameters(10);   % Heat transfer area
    
    dT_c = (v_c/V_c) * ( T_c_I - T_c) + ((S*K)/(ro_c*c_c*V_c)) * (T_h - T_c);
    
    dT_h = (v_h/V_h) * ( T_h_I - T_h) + ((S*K)/(ro_h*c_h*V_h)) * (T_c - T_h);
    
    sys = [dT_h dT_c]';
    
  case 3                                                % Output equation
    sys = x;
end
