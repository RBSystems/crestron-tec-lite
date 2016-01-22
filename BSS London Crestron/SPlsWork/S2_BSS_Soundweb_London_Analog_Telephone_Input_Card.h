#ifndef __S2_BSS_SOUNDWEB_LONDON_ANALOG_TELEPHONE_INPUT_CARD_H__
#define __S2_BSS_SOUNDWEB_LONDON_ANALOG_TELEPHONE_INPUT_CARD_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_SUBSCRIBE$_DIG_INPUT 0
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_UNSUBSCRIBE$_DIG_INPUT 1
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_METER_SUBSCRIBE$_DIG_INPUT 2
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_BUTTON_1$_DIG_INPUT 3
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_BUTTON_2$_DIG_INPUT 4
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_BUTTON_3$_DIG_INPUT 5
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_BUTTON_4$_DIG_INPUT 6
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_BUTTON_5$_DIG_INPUT 7
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_BUTTON_6$_DIG_INPUT 8
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_BUTTON_7$_DIG_INPUT 9
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_BUTTON_8$_DIG_INPUT 10
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_BUTTON_9$_DIG_INPUT 11
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_BUTTON_0$_DIG_INPUT 12
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_BUTTON_PAUSE$_DIG_INPUT 13
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_BUTTON_DELETE$_DIG_INPUT 14
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_BUTTON_REDIAL$_DIG_INPUT 15
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_BUTTON_INTERNATIONAL_PLUS$_DIG_INPUT 16
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_BUTTON_BACKSPACE$_DIG_INPUT 17
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_BUTTON_FLASH$_DIG_INPUT 18
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_BUTTON___LB__$_DIG_INPUT 19
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_BUTTON_ASTERISK$_DIG_INPUT 20
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_HANG_UP$_DIG_INPUT 21
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_DIAL$_DIG_INPUT 22
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_TOGGLE_DIAL_HANG_UP$_DIG_INPUT 23
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_TX_MUTEON$_DIG_INPUT 24
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_TX_MUTEOFF$_DIG_INPUT 25
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_TX_MUTETOGGLE$_DIG_INPUT 26
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_RX_MUTEON$_DIG_INPUT 27
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_RX_MUTEOFF$_DIG_INPUT 28
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_RX_MUTETOGGLE$_DIG_INPUT 29

#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_SPEED_STORE$_DIG_INPUT 30
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_SPEED_STORE$_ARRAY_LENGTH 16
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_SPEED_DIAL$_DIG_INPUT 46
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_SPEED_DIAL$_ARRAY_LENGTH 16

/*
* ANALOG_INPUT
*/
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_AUTO_ANSWER$_ANALOG_INPUT 0
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_TX_GAIN$_ANALOG_INPUT 1
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_RX_GAIN$_ANALOG_INPUT 2
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_DTMF_GAIN$_ANALOG_INPUT 3
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_DIAL_TONE_GAIN$_ANALOG_INPUT 4
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_RING_GAIN$_ANALOG_INPUT 5


#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_RX$_BUFFER_INPUT 6
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_RX$_BUFFER_MAX_LEN 400
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Analog_Telephone_Input_Card, __RX$, __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_RX$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_INCOMING_CALL_FB$_DIG_OUTPUT 0
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_HOOK_STATUS_FB$_DIG_OUTPUT 1
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_TX_MUTE_FB$_DIG_OUTPUT 2
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_RX_MUTE_FB$_DIG_OUTPUT 3

#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_SPEED_DIAL_FB$_DIG_OUTPUT 4
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_SPEED_DIAL_FB$_ARRAY_LENGTH 16

/*
* ANALOG_OUTPUT
*/
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_AUTO_ANSWER_FB$_ANALOG_OUTPUT 0
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_TX_GAIN_FB$_ANALOG_OUTPUT 1
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_TX_METER_FB$_ANALOG_OUTPUT 2
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_RX_GAIN_FB$_ANALOG_OUTPUT 3
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_RX_METER_FB$_ANALOG_OUTPUT 4
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_DTMF_GAIN_FB$_ANALOG_OUTPUT 5
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_DIAL_TONE_GAIN_FB$_ANALOG_OUTPUT 6
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_RING_GAIN_FB$_ANALOG_OUTPUT 7

#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_TX$_STRING_OUTPUT 8
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_PHONE_NUMBER_FB$_STRING_OUTPUT 9


/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_METER_RATE$_INTEGER_PARAMETER 10
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
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_CARD$_STRING_PARAMETER 11
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_CARD$_PARAM_MAX_LEN 3
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Analog_Telephone_Input_Card, __CARD$, __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_CARD$_PARAM_MAX_LEN );


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
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_TEMPSTRING_STRING_MAX_LEN 40
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Analog_Telephone_Input_Card, __TEMPSTRING, __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_TEMPSTRING_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_RETURNSTRING_STRING_MAX_LEN 4
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Analog_Telephone_Input_Card, __RETURNSTRING, __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_RETURNSTRING_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_MAINSTR1_STRING_MAX_LEN 32
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Analog_Telephone_Input_Card, __MAINSTR1, __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_MAINSTR1_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_MAINSTR2_STRING_MAX_LEN 32
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Analog_Telephone_Input_Card, __MAINSTR2, __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_MAINSTR2_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_MAINSTR3_STRING_MAX_LEN 32
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Analog_Telephone_Input_Card, __MAINSTR3, __S2_BSS_Soundweb_London_Analog_Telephone_Input_Card_MAINSTR3_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_BSS_Soundweb_London_Analog_Telephone_Input_Card )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __SPEED_STORE$ );
   DECLARE_IO_ARRAY( __SPEED_DIAL$ );
   DECLARE_IO_ARRAY( __SPEED_DIAL_FB$ );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Analog_Telephone_Input_Card, __RX$ );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Analog_Telephone_Input_Card, __CARD$ );
};

START_NVRAM_VAR_STRUCT( S2_BSS_Soundweb_London_Analog_Telephone_Input_Card )
{
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Analog_Telephone_Input_Card, __TEMPSTRING );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Analog_Telephone_Input_Card, __RETURNSTRING );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Analog_Telephone_Input_Card, __MAINSTR1 );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Analog_Telephone_Input_Card, __MAINSTR2 );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Analog_Telephone_Input_Card, __MAINSTR3 );
   unsigned short __XOK;
   unsigned short __RETURNI;
   unsigned short __SUBSCRIBE;
   unsigned short __XOKSUBSCRIBE;
   unsigned short __METER_SUBSCRIBE;
   unsigned short __I;
   unsigned short __XSAVE;
   unsigned short __XDIAL;
   unsigned short __STATEVARVALUE;
   unsigned short __STATEVARPHANTOM;
   unsigned short __STATEVARRECEIVE;
   unsigned short __STATEVARSAVE;
   unsigned short __STATEVARDIAL;
   unsigned short __VOLUMEINPUT;
   unsigned short __VOLUME;
   unsigned short __TX_GAIN;
   unsigned short __XOKTX_GAIN;
   unsigned short __RX_GAIN;
   unsigned short __XOKRX_GAIN;
   unsigned short __DTMF_GAIN;
   unsigned short __XOKDTMF_GAIN;
   unsigned short __DIAL_TONE_GAIN;
   unsigned short __XOKDIAL_TONE_GAIN;
   unsigned short __RING_GAIN;
   unsigned short __XOKRING_GAIN;
   unsigned short __MAINREC1;
   unsigned short __MAINREC2;
   unsigned short __MAINREC3;
};

DEFINE_WAITEVENT( S2_BSS_Soundweb_London_Analog_Telephone_Input_Card, __SPLS_TMPVAR__WAITLABEL_0__ );
DEFINE_WAITEVENT( S2_BSS_Soundweb_London_Analog_Telephone_Input_Card, __SPLS_TMPVAR__WAITLABEL_1__ );


#endif //__S2_BSS_SOUNDWEB_LONDON_ANALOG_TELEPHONE_INPUT_CARD_H__

