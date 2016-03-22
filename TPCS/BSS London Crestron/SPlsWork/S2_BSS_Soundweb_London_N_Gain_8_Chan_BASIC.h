#ifndef __S2_BSS_SOUNDWEB_LONDON_N_GAIN_8_CHAN_BASIC_H__
#define __S2_BSS_SOUNDWEB_LONDON_N_GAIN_8_CHAN_BASIC_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_ENABLE_FEEDBACK$_DIG_INPUT 0
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_DISABLE_FEEDBACK$_DIG_INPUT 1
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN1_MUTE$_DIG_INPUT 2
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN2_MUTE$_DIG_INPUT 3
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN3_MUTE$_DIG_INPUT 4
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN4_MUTE$_DIG_INPUT 5
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN5_MUTE$_DIG_INPUT 6
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN6_MUTE$_DIG_INPUT 7
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN7_MUTE$_DIG_INPUT 8
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN8_MUTE$_DIG_INPUT 9
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_MASTEROUT_MUTE$_DIG_INPUT 10


/*
* ANALOG_INPUT
*/
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN_OFFSET$_ANALOG_INPUT 0
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN1_VOL$_ANALOG_INPUT 1
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN2_VOL$_ANALOG_INPUT 2
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN3_VOL$_ANALOG_INPUT 3
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN4_VOL$_ANALOG_INPUT 4
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN5_VOL$_ANALOG_INPUT 5
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN6_VOL$_ANALOG_INPUT 6
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN7_VOL$_ANALOG_INPUT 7
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN8_VOL$_ANALOG_INPUT 8
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_MASTERVOL$_ANALOG_INPUT 9


#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_RX$_BUFFER_INPUT 10
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_RX$_BUFFER_MAX_LEN 400
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC, __RX$, __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_RX$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN1_MUTE_FB$_DIG_OUTPUT 0
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN2_MUTE_FB$_DIG_OUTPUT 1
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN3_MUTE_FB$_DIG_OUTPUT 2
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN4_MUTE_FB$_DIG_OUTPUT 3
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN5_MUTE_FB$_DIG_OUTPUT 4
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN6_MUTE_FB$_DIG_OUTPUT 5
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN7_MUTE_FB$_DIG_OUTPUT 6
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN8_MUTE_FB$_DIG_OUTPUT 7
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_MASTEROUT_MUTE_FB$_DIG_OUTPUT 8


/*
* ANALOG_OUTPUT
*/
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN1_VOL_FB$_ANALOG_OUTPUT 0
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN2_VOL_FB$_ANALOG_OUTPUT 1
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN3_VOL_FB$_ANALOG_OUTPUT 2
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN4_VOL_FB$_ANALOG_OUTPUT 3
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN5_VOL_FB$_ANALOG_OUTPUT 4
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN6_VOL_FB$_ANALOG_OUTPUT 5
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN7_VOL_FB$_ANALOG_OUTPUT 6
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_CHAN8_VOL_FB$_ANALOG_OUTPUT 7
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_MASTERVOL_FB$_ANALOG_OUTPUT 8

#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_TX$_STRING_OUTPUT 9


/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* STRING_PARAMETER
*/
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_OBJECTID$_STRING_PARAMETER 10
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_OBJECTID$_PARAM_MAX_LEN 3
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC, __OBJECTID$, __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_OBJECTID$_PARAM_MAX_LEN );


/*
* INTEGER
*/


/*
* LONG_INTEGER
*/


/*
* SIGNED_INTEGER
*/


/*
* SIGNED_LONG_INTEGER
*/


/*
* STRING
*/
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_RETURNSTRING_STRING_MAX_LEN 4
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC, __RETURNSTRING, __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_RETURNSTRING_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_TEMPSTRING_STRING_MAX_LEN 40
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC, __TEMPSTRING, __S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC_TEMPSTRING_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC, __RX$ );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC, __OBJECTID$ );
};

START_NVRAM_VAR_STRUCT( S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC )
{
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC, __RETURNSTRING );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC, __TEMPSTRING );
   unsigned short __OFFSET;
   unsigned short __FEEDBACK;
   unsigned short __STATEVAR;
   unsigned short __SV;
   unsigned short __STATEVARSUB;
   unsigned short __STATEVARUNSUB;
   unsigned short __RETURNI;
   unsigned short __CHAN1_VOL;
   unsigned short __CHAN2_VOL;
   unsigned short __CHAN3_VOL;
   unsigned short __CHAN4_VOL;
   unsigned short __CHAN5_VOL;
   unsigned short __CHAN6_VOL;
   unsigned short __CHAN7_VOL;
   unsigned short __CHAN8_VOL;
   unsigned short __MASTERVOL;
   unsigned short __XOK;
   unsigned short __XOKFEEDBACK;
   unsigned short __I;
   unsigned short __VOLUME;
   unsigned short __XOKCHAN1_VOL;
   unsigned short __XOKCHAN2_VOL;
   unsigned short __XOKCHAN3_VOL;
   unsigned short __XOKCHAN4_VOL;
   unsigned short __XOKCHAN5_VOL;
   unsigned short __XOKCHAN6_VOL;
   unsigned short __XOKCHAN7_VOL;
   unsigned short __XOKCHAN8_VOL;
   unsigned short __XOKMASTERVOL;
};

DEFINE_WAITEVENT( S2_BSS_Soundweb_London_N_Gain_8_Chan_BASIC, __SPLS_TMPVAR__WAITLABEL_0__ );


#endif //__S2_BSS_SOUNDWEB_LONDON_N_GAIN_8_CHAN_BASIC_H__

