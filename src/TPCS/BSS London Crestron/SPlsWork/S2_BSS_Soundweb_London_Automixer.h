#ifndef __S2_BSS_SOUNDWEB_LONDON_AUTOMIXER_H__
#define __S2_BSS_SOUNDWEB_LONDON_AUTOMIXER_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_BSS_Soundweb_London_Automixer_MUTE$_DIG_INPUT 0
#define __S2_BSS_Soundweb_London_Automixer_UNMUTE$_DIG_INPUT 1
#define __S2_BSS_Soundweb_London_Automixer_POLARITYON$_DIG_INPUT 2
#define __S2_BSS_Soundweb_London_Automixer_POLARITYOFF$_DIG_INPUT 3
#define __S2_BSS_Soundweb_London_Automixer_ROUTETOGROUP1ON$_DIG_INPUT 4
#define __S2_BSS_Soundweb_London_Automixer_ROUTETOGROUP2ON$_DIG_INPUT 5
#define __S2_BSS_Soundweb_London_Automixer_ROUTETOGROUP3ON$_DIG_INPUT 6
#define __S2_BSS_Soundweb_London_Automixer_ROUTETOGROUP4ON$_DIG_INPUT 7
#define __S2_BSS_Soundweb_London_Automixer_ROUTETOGROUP1OFF$_DIG_INPUT 8
#define __S2_BSS_Soundweb_London_Automixer_ROUTETOGROUP2OFF$_DIG_INPUT 9
#define __S2_BSS_Soundweb_London_Automixer_ROUTETOGROUP3OFF$_DIG_INPUT 10
#define __S2_BSS_Soundweb_London_Automixer_ROUTETOGROUP4OFF$_DIG_INPUT 11
#define __S2_BSS_Soundweb_London_Automixer_SOLOON$_DIG_INPUT 12
#define __S2_BSS_Soundweb_London_Automixer_SOLOOFF$_DIG_INPUT 13
#define __S2_BSS_Soundweb_London_Automixer_OVERRIDEON$_DIG_INPUT 14
#define __S2_BSS_Soundweb_London_Automixer_OVERRIDEOFF$_DIG_INPUT 15
#define __S2_BSS_Soundweb_London_Automixer_AUTOON$_DIG_INPUT 16
#define __S2_BSS_Soundweb_London_Automixer_AUTOOFF$_DIG_INPUT 17
#define __S2_BSS_Soundweb_London_Automixer_SUBSCRIBE$_DIG_INPUT 18
#define __S2_BSS_Soundweb_London_Automixer_UNSUBSCRIBE$_DIG_INPUT 19


/*
* ANALOG_INPUT
*/
#define __S2_BSS_Soundweb_London_Automixer_GAIN$_ANALOG_INPUT 0
#define __S2_BSS_Soundweb_London_Automixer_PAN$_ANALOG_INPUT 1
#define __S2_BSS_Soundweb_London_Automixer_OFFGAIN$_ANALOG_INPUT 2
#define __S2_BSS_Soundweb_London_Automixer_INPUT$_ANALOG_INPUT 3


#define __S2_BSS_Soundweb_London_Automixer_RX$_BUFFER_INPUT 4
#define __S2_BSS_Soundweb_London_Automixer_RX$_BUFFER_MAX_LEN 400
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Automixer, __RX$, __S2_BSS_Soundweb_London_Automixer_RX$_BUFFER_MAX_LEN );

#define __S2_BSS_Soundweb_London_Automixer_AUX$_ANALOG_INPUT 5
#define __S2_BSS_Soundweb_London_Automixer_AUX$_ARRAY_LENGTH 4

/*
* DIGITAL_OUTPUT
*/
#define __S2_BSS_Soundweb_London_Automixer_MUTE_FB$_DIG_OUTPUT 0
#define __S2_BSS_Soundweb_London_Automixer_POLARITY_FB$_DIG_OUTPUT 1
#define __S2_BSS_Soundweb_London_Automixer_ROUTETOGROUP1_FB$_DIG_OUTPUT 2
#define __S2_BSS_Soundweb_London_Automixer_ROUTETOGROUP2_FB$_DIG_OUTPUT 3
#define __S2_BSS_Soundweb_London_Automixer_ROUTETOGROUP3_FB$_DIG_OUTPUT 4
#define __S2_BSS_Soundweb_London_Automixer_ROUTETOGROUP4_FB$_DIG_OUTPUT 5
#define __S2_BSS_Soundweb_London_Automixer_SOLO_FB$_DIG_OUTPUT 6
#define __S2_BSS_Soundweb_London_Automixer_OVERRIDE_FB$_DIG_OUTPUT 7
#define __S2_BSS_Soundweb_London_Automixer_AUTO_FB$_DIG_OUTPUT 8


/*
* ANALOG_OUTPUT
*/
#define __S2_BSS_Soundweb_London_Automixer_GAIN_FB$_ANALOG_OUTPUT 0
#define __S2_BSS_Soundweb_London_Automixer_PAN_FB$_ANALOG_OUTPUT 1
#define __S2_BSS_Soundweb_London_Automixer_OFFGAIN_FB$_ANALOG_OUTPUT 2

#define __S2_BSS_Soundweb_London_Automixer_TX$_STRING_OUTPUT 3

#define __S2_BSS_Soundweb_London_Automixer_AUX_FB$_ANALOG_OUTPUT 4
#define __S2_BSS_Soundweb_London_Automixer_AUX_FB$_ARRAY_LENGTH 4

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
#define __S2_BSS_Soundweb_London_Automixer_OBJECTID$_STRING_PARAMETER 10
#define __S2_BSS_Soundweb_London_Automixer_OBJECTID$_PARAM_MAX_LEN 3
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Automixer, __OBJECTID$, __S2_BSS_Soundweb_London_Automixer_OBJECTID$_PARAM_MAX_LEN );


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
#define __S2_BSS_Soundweb_London_Automixer_RETURNSTRING_STRING_MAX_LEN 4
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Automixer, __RETURNSTRING, __S2_BSS_Soundweb_London_Automixer_RETURNSTRING_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_Automixer_TEMPSTRING_STRING_MAX_LEN 40
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Automixer, __TEMPSTRING, __S2_BSS_Soundweb_London_Automixer_TEMPSTRING_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_BSS_Soundweb_London_Automixer )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __AUX$ );
   DECLARE_IO_ARRAY( __AUX_FB$ );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Automixer, __RX$ );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Automixer, __OBJECTID$ );
};

START_NVRAM_VAR_STRUCT( S2_BSS_Soundweb_London_Automixer )
{
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Automixer, __RETURNSTRING );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Automixer, __TEMPSTRING );
   unsigned short __STATEVAR;
   unsigned short __STATEVARSUB;
   unsigned short __STATEVARUNSUB;
   unsigned short __SUBSCRIBE;
   unsigned short __XROUTE;
   unsigned short __XAUX;
   unsigned short __XSUBSCRIBE;
   unsigned short __XUNSUBSCRIBE;
   unsigned short __INPUT;
   unsigned short __VOLUME;
   unsigned short __RETURNI;
   unsigned short __XOK;
   unsigned short __XOKGAIN;
   unsigned short __XOKOFFGAIN;
   unsigned short __XOKSUBSCRIBE;
   unsigned short __VOLUMEINPUT;
   unsigned short __RXSV;
};

DEFINE_WAITEVENT( S2_BSS_Soundweb_London_Automixer, __SPLS_TMPVAR__WAITLABEL_0__ );


#endif //__S2_BSS_SOUNDWEB_LONDON_AUTOMIXER_H__

