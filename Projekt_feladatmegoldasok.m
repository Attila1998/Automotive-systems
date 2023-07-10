close all;
clear all;
clc;

load('HEX_Parameters.mat'); % adatbetoltes

%Állandósult állapot tanulmányozása

Tref=50; %referencia homerseklet
T_c=Tref; 
T_c_I=T_c*K_l % a szekunder bementi homerseklet

T_h = (-((v_c/V_c)*(T_c_I-T_c))/((K*S)/(ro_c*V_c*c_c))) + T_c
v_h = (-(((K*S)/(ro_h*V_c*c_h))*(T_c-T_h))/(T_h_I-T_h))*V_h

erosites = T_c / v_h 


