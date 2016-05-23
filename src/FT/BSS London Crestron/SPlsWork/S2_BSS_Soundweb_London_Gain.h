#ifndef __S2_BSS_SOUNDWEB_LONDON_GAIN_H__
#define __S2_BSS_SOUNDWEB_LONDON_GAIN_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_BSS_Soundweb_London_Gain_SUBSCRIBE$_DIG_INPUT 0
#define __S2_BSS_Soundweb_London_Gain_UNSUBSCRIBE$_DIG_INPUT 1
#define __S2_BSS_Soundweb_London_Gain_MUTE$_DIG_INPUT 2
#define __S2_BSS_Soundweb_London_Gain_UNMUTE$_DIG_INPUT 3
#define __S2_BSS_Soundweb_London_Gain_POLARITYON$_DIG_INPUT 4
#define __S2_BSS_Soundweb_London_Gain_POLARITYOFF$_DIG_INPUT 5


/*
* ANALOG_INPUT
*/
#define __S2_BSS_Soundweb_London_Gain_GAIN$_ANALOG_INPUT 0


#define __S2_BSS_Soundweb_London_Gain_RX$_BUFFER_INPUT 1
#define __S2_BSS_Soundweb_London_Gain_RX$_BUFFER_MAX_LEN 400
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Gain, __RX$, __S2_BSS_Soundweb_London_Gain_RX$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_BSS_Soundweb_London_Gain_MUTE_FB$_DIG_OUTPUT 0
#define __S2_BSS_Soundweb_London_Gain_POLARITY_FB$_DIG_OUTPUT 1


/*
* ANALOG_OUTPUT
*/
#define __S2_BSS_Soundweb_London_Gain_GAIN_FB$_ANALOG_OUTPUT 0

#define __S2_BSS_Soundweb_London_Gain_TX$_STRING_OUTPUT 1


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
#define __S2_BSS_Soundweb_London_Gain_OBJECTID$_STRING_PARAMETER 10
#define __S2_BSS_Soundweb_London_Gain_OBJECTID$_PARAM_MAX_LEN 3
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Gain, __OBJECTID$, __S2_BSS_Soundweb_London_Gain_OBJECTID$_PARAM_MAX_LEN );


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
#define __S2_BSS_Soundweb_London_Gain_RETURNSTRING_STRING_MAX_LEN 4
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Gain, __RETURNSTRING, __S2_BSS_Soundweb_London_Gain_RETURNSTRING_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_Gain_TEMPSTRING_STRING_MAX_LEN 40
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Gain, __TEMPSTRING, __S2_BSS_Soundweb_London_Gain_TEMPSTRING_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_BSS_Soundweb_London_Gain )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Gain, __RX$ );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Gain, __OBJECTID$ );
};

START_NVRAM_VAR_STRUCT( S2_BSS_Soundweb_London_Gain )
{
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Gain, __RETURNSTRING );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Gain, __TEMPSTRING );
   unsigned short __I;
   unsigned short __SUBSCRIBE;
   unsigned short __VOLUME;
   unsigned short __RETURNI;
   unsigned short __XOK;
   unsigned short __XOKSUBSCRIBE;
   unsigned short __VOLUMEINPUT;
   unsigned short __XOKGAIN;
};

DEFINE_WAITEVENT( S2_BSS_Soundweb_London_Gain, __SPLS_TMPVAR__WAITLABEL_0__ );


#endif //__S2_BSS_SOUNDWEB_LONDON_GAIN_H__

