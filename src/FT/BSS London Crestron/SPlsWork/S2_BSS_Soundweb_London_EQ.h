#ifndef __S2_BSS_SOUNDWEB_LONDON_EQ_H__
#define __S2_BSS_SOUNDWEB_LONDON_EQ_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_BSS_Soundweb_London_EQ_SUBSCRIBE$_DIG_INPUT 0
#define __S2_BSS_Soundweb_London_EQ_UNSUBSCRIBE$_DIG_INPUT 1
#define __S2_BSS_Soundweb_London_EQ_BYPASS_ON$_DIG_INPUT 2
#define __S2_BSS_Soundweb_London_EQ_BYPASS_OFF$_DIG_INPUT 3


/*
* ANALOG_INPUT
*/
#define __S2_BSS_Soundweb_London_EQ_INPUT$_ANALOG_INPUT 0
#define __S2_BSS_Soundweb_London_EQ_BOOSTPERCENT$_ANALOG_INPUT 1
#define __S2_BSS_Soundweb_London_EQ_WIDTH$_ANALOG_INPUT 2
#define __S2_BSS_Soundweb_London_EQ_FREQUENCY$_ANALOG_INPUT 3
#define __S2_BSS_Soundweb_London_EQ_TYPE$_ANALOG_INPUT 4
#define __S2_BSS_Soundweb_London_EQ_SLOPE$_ANALOG_INPUT 5


#define __S2_BSS_Soundweb_London_EQ_RX$_BUFFER_INPUT 6
#define __S2_BSS_Soundweb_London_EQ_RX$_BUFFER_MAX_LEN 400
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_EQ, __RX$, __S2_BSS_Soundweb_London_EQ_RX$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_BSS_Soundweb_London_EQ_BYPASS_FB$_DIG_OUTPUT 0


/*
* ANALOG_OUTPUT
*/
#define __S2_BSS_Soundweb_London_EQ_BOOSTPERCENT_FB$_ANALOG_OUTPUT 0
#define __S2_BSS_Soundweb_London_EQ_WIDTH_FB$_ANALOG_OUTPUT 1
#define __S2_BSS_Soundweb_London_EQ_FREQUENCY_FB$_ANALOG_OUTPUT 2
#define __S2_BSS_Soundweb_London_EQ_TYPE_FB$_ANALOG_OUTPUT 3
#define __S2_BSS_Soundweb_London_EQ_SLOPE_FB$_ANALOG_OUTPUT 4

#define __S2_BSS_Soundweb_London_EQ_TX$_STRING_OUTPUT 5
#define __S2_BSS_Soundweb_London_EQ_BOOSTSTRING_FB$_STRING_OUTPUT 6
#define __S2_BSS_Soundweb_London_EQ_WIDTHSTRING_FB$_STRING_OUTPUT 7
#define __S2_BSS_Soundweb_London_EQ_FREQUENCYSTRING_FB$_STRING_OUTPUT 8
#define __S2_BSS_Soundweb_London_EQ_TYPESTRING_FB$_STRING_OUTPUT 9
#define __S2_BSS_Soundweb_London_EQ_SLOPESTRING_FB$_STRING_OUTPUT 10


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
#define __S2_BSS_Soundweb_London_EQ_OBJECTID$_STRING_PARAMETER 10
#define __S2_BSS_Soundweb_London_EQ_OBJECTID$_PARAM_MAX_LEN 3
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_EQ, __OBJECTID$, __S2_BSS_Soundweb_London_EQ_OBJECTID$_PARAM_MAX_LEN );


/*
* INTEGER
*/
CREATE_INTARRAY1D( S2_BSS_Soundweb_London_EQ, __WIDTH, 101 );;
CREATE_INTARRAY1D( S2_BSS_Soundweb_London_EQ, __FREQUENCY, 101 );;


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
#define __S2_BSS_Soundweb_London_EQ_RETURNSTRING_STRING_MAX_LEN 4
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_EQ, __RETURNSTRING, __S2_BSS_Soundweb_London_EQ_RETURNSTRING_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_EQ_TEMPSTRING_STRING_MAX_LEN 40
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_EQ, __TEMPSTRING, __S2_BSS_Soundweb_London_EQ_TEMPSTRING_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_EQ_NOTCH_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_EQ, __NOTCH, __S2_BSS_Soundweb_London_EQ_NOTCH_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_EQ_NEGATIVE_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_EQ, __NEGATIVE, __S2_BSS_Soundweb_London_EQ_NEGATIVE_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_EQ_BOOSTSTRING_ARRAY_NUM_ELEMS 101
#define __S2_BSS_Soundweb_London_EQ_BOOSTSTRING_ARRAY_NUM_CHARS 20
CREATE_STRING_ARRAY( S2_BSS_Soundweb_London_EQ, __BOOSTSTRING, __S2_BSS_Soundweb_London_EQ_BOOSTSTRING_ARRAY_NUM_ELEMS, __S2_BSS_Soundweb_London_EQ_BOOSTSTRING_ARRAY_NUM_CHARS );
#define __S2_BSS_Soundweb_London_EQ_WIDTHSTRING_ARRAY_NUM_ELEMS 101
#define __S2_BSS_Soundweb_London_EQ_WIDTHSTRING_ARRAY_NUM_CHARS 20
CREATE_STRING_ARRAY( S2_BSS_Soundweb_London_EQ, __WIDTHSTRING, __S2_BSS_Soundweb_London_EQ_WIDTHSTRING_ARRAY_NUM_ELEMS, __S2_BSS_Soundweb_London_EQ_WIDTHSTRING_ARRAY_NUM_CHARS );
#define __S2_BSS_Soundweb_London_EQ_FREQUENCYSTRING_ARRAY_NUM_ELEMS 101
#define __S2_BSS_Soundweb_London_EQ_FREQUENCYSTRING_ARRAY_NUM_CHARS 20
CREATE_STRING_ARRAY( S2_BSS_Soundweb_London_EQ, __FREQUENCYSTRING, __S2_BSS_Soundweb_London_EQ_FREQUENCYSTRING_ARRAY_NUM_ELEMS, __S2_BSS_Soundweb_London_EQ_FREQUENCYSTRING_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_BSS_Soundweb_London_EQ )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_EQ, __RX$ );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_EQ, __OBJECTID$ );
};

START_NVRAM_VAR_STRUCT( S2_BSS_Soundweb_London_EQ )
{
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_EQ, __RETURNSTRING );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_EQ, __TEMPSTRING );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_EQ, __NOTCH );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_EQ, __NEGATIVE );
   DECLARE_STRING_ARRAY( S2_BSS_Soundweb_London_EQ, __BOOSTSTRING );
   DECLARE_STRING_ARRAY( S2_BSS_Soundweb_London_EQ, __WIDTHSTRING );
   DECLARE_STRING_ARRAY( S2_BSS_Soundweb_London_EQ, __FREQUENCYSTRING );
   unsigned short __I;
   unsigned short __VOLUME;
   unsigned short __ROUNDPART;
   unsigned short __VALUE;
   unsigned short __VOLUMEINPUT;
   unsigned short __INPUT;
   unsigned short __RETURNI;
   unsigned short __XOK;
   unsigned short __XOKSUBSCRIBE;
   unsigned short __XOKBOOST;
   unsigned short __SUBSCRIBE;
   unsigned short __ICASE;
   unsigned short __STATEVARBOOST;
   unsigned short __STATEVARFREQUENCY;
   unsigned short __STATEVARSUB;
   unsigned short __STATEVARRECEIVE;
   unsigned short __X;
   unsigned short __STATEVARWIDTH;
   unsigned short __STATEVARSLOPE;
   unsigned short __STATEVARTYPE;
   unsigned short __STATEVARBYPASS;
   DECLARE_INTARRAY( S2_BSS_Soundweb_London_EQ, __WIDTH );
   DECLARE_INTARRAY( S2_BSS_Soundweb_London_EQ, __FREQUENCY );
};

DEFINE_WAITEVENT( S2_BSS_Soundweb_London_EQ, __SPLS_TMPVAR__WAITLABEL_0__ );


#endif //__S2_BSS_SOUNDWEB_LONDON_EQ_H__

