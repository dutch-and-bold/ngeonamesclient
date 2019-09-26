namespace DutchAndBold.NGeoNamesClient.Entities
{
    public enum FeatureCode
    {
        /// <summary>
        /// first-order administrative division	a primary administrative division of a country, such as a state in the United States
        /// </summary>
        ADM1,

        /// <summary>
        /// historical first-order administrative division	a former first-order administrative division
        /// </summary>
        ADM1H,

        /// <summary>
        /// second-order administrative division	a subdivision of a first-order administrative division
        /// </summary>
        ADM2,

        /// <summary>
        /// historical second-order administrative division	a former second-order administrative division
        /// </summary>
        ADM2H,

        /// <summary>
        /// third-order administrative division	a subdivision of a second-order administrative division
        /// </summary>
        ADM3,

        /// <summary>
        /// historical third-order administrative division	a former third-order administrative division
        /// </summary>
        ADM3H,

        /// <summary>
        /// fourth-order administrative division	a subdivision of a third-order administrative division
        /// </summary>
        ADM4,

        /// <summary>
        /// historical fourth-order administrative division	a former fourth-order administrative division
        /// </summary>
        ADM4H,

        /// <summary>
        /// fifth-order administrative division	a subdivision of a fourth-order administrative division
        /// </summary>
        ADM5,

        /// <summary>
        /// administrative division	an administrative division of a country, undifferentiated as to administrative level
        /// </summary>
        ADMD,

        /// <summary>
        /// historical administrative division	a former administrative division of a political entity, undifferentiated as to administrative level
        /// </summary>
        ADMDH,

        /// <summary>
        /// leased area	a tract of land leased to another country, usually for military installations
        /// </summary>
        LTER,

        /// <summary>
        /// political entity
        /// </summary>
        PCL,

        /// <summary>
        /// dependent political entity
        /// </summary>
        PCLD,

        /// <summary>
        /// freely associated state
        /// </summary>
        PCLF,

        /// <summary>
        /// historical political entity	a former political entity
        /// </summary>
        PCLH,

        /// <summary>
        /// independent political entity
        /// </summary>
        PCLI,

        /// <summary>
        /// section of independent political entity
        /// </summary>
        PCLIX,

        /// <summary>
        /// semi-independent political entity
        /// </summary>
        PCLS,

        /// <summary>
        /// parish	an ecclesiastical district
        /// </summary>
        PRSH,

        /// <summary>
        /// territory
        /// </summary>
        TERR,

        /// <summary>
        /// zone
        /// </summary>
        ZN,

        /// <summary>
        /// buffer zone	a zone recognized as a buffer between two nations in which military presence is minimal or absent
        /// </summary>
        ZNB,
        
        /// <summary>
        /// seaplane landing area	a place on a waterbody where floatplanes land and take off
        /// </summary>
        AIRS,

        /// <summary>
        /// anchorage	an area where vessels may anchor
        /// </summary>
        ANCH,

        /// <summary>
        /// bay	a coastal indentation between two capes or headlands, larger than a cove but smaller than a gulf
        /// </summary>
        BAY,

        /// <summary>
        /// bays	coastal indentations between two capes or headlands, larger than a cove but smaller than a gulf
        /// </summary>
        BAYS,

        /// <summary>
        /// bight(s)	an open body of water forming a slight recession in a coastline
        /// </summary>
        BGHT,

        /// <summary>
        /// bank(s)	an elevation, typically located on a shelf, over which the depth of water is relatively shallow but sufficient for most surface navigation
        /// </summary>
        BNK,

        /// <summary>
        /// stream bank	a sloping margin of a stream channel which normally confines the stream to its channel on land
        /// </summary>
        BNKR,

        /// <summary>
        /// section of bank
        /// </summary>
        BNKX,

        /// <summary>
        /// bog(s)	a wetland characterized by peat forming sphagnum moss, sedge, and other acid-water plants
        /// </summary>
        BOG,

        /// <summary>
        /// icecap	a dome-shaped mass of glacial ice covering an area of mountain summits or other high lands; smaller than an ice sheet
        /// </summary>
        CAPG,

        /// <summary>
        /// channel	the deepest part of a stream, bay, lagoon, or strait, through which the main current flows
        /// </summary>
        CHN,

        /// <summary>
        /// lake channel(s)	that part of a lake having water deep enough for navigation between islands, shoals, etc.
        /// </summary>
        CHNL,

        /// <summary>
        /// marine channel	that part of a body of water deep enough for navigation through an area otherwise not suitable
        /// </summary>
        CHNM,

        /// <summary>
        /// navigation channel	a buoyed channel of sufficient depth for the safe navigation of vessels
        /// </summary>
        CHNN,

        /// <summary>
        /// confluence	a place where two or more streams or intermittent streams flow together
        /// </summary>
        CNFL,

        /// <summary>
        /// canal	an artificial watercourse
        /// </summary>
        CNL,

        /// <summary>
        /// aqueduct	a conduit used to carry water
        /// </summary>
        CNLA,

        /// <summary>
        /// canal bend	a conspicuously curved or bent section of a canal
        /// </summary>
        CNLB,

        /// <summary>
        /// drainage canal	an artificial waterway carrying water away from a wetland or from drainage ditches
        /// </summary>
        CNLD,

        /// <summary>
        /// irrigation canal	a canal which serves as a main conduit for irrigation water
        /// </summary>
        CNLI,

        /// <summary>
        /// navigation canal(s)	a watercourse constructed for navigation of vessels
        /// </summary>
        CNLN,

        /// <summary>
        /// abandoned canal
        /// </summary>
        CNLQ,

        /// <summary>
        /// underground irrigation canal(s)	a gently inclined underground tunnel bringing water for irrigation from aquifers
        /// </summary>
        CNLSB,

        /// <summary>
        /// section of canal
        /// </summary>
        CNLX,

        /// <summary>
        /// cove(s)	a small coastal indentation, smaller than a bay
        /// </summary>
        COVE,

        /// <summary>
        /// tidal creek(s)	a meandering channel in a coastal wetland subject to bi-directional tidal currents
        /// </summary>
        CRKT,

        /// <summary>
        /// current	a horizontal flow of water in a given direction with uniform velocity
        /// </summary>
        CRNT,

        /// <summary>
        /// cutoff	a channel formed as a result of a stream cutting through a meander neck
        /// </summary>
        CUTF,

        /// <summary>
        /// dock(s)	a waterway between two piers, or cut into the land for the berthing of ships
        /// </summary>
        DCK,

        /// <summary>
        /// docking basin	a part of a harbor where ships dock
        /// </summary>
        DCKB,

        /// <summary>
        /// icecap dome	a comparatively elevated area on an icecap
        /// </summary>
        DOMG,

        /// <summary>
        /// icecap depression	a comparatively depressed area on an icecap
        /// </summary>
        DPRG,

        /// <summary>
        /// ditch	a small artificial watercourse dug for draining or irrigating the land
        /// </summary>
        DTCH,

        /// <summary>
        /// drainage ditch	a ditch which serves to drain the land
        /// </summary>
        DTCHD,

        /// <summary>
        /// irrigation ditch	a ditch which serves to distribute irrigation water
        /// </summary>
        DTCHI,

        /// <summary>
        /// ditch mouth(s)	an area where a drainage ditch enters a lagoon, lake or bay
        /// </summary>
        DTCHM,

        /// <summary>
        /// estuary	a funnel-shaped stream mouth or embayment where fresh water mixes with sea water under tidal influences
        /// </summary>
        ESTY,

        /// <summary>
        /// fishing area	a fishing ground, bank or area where fishermen go to catch fish
        /// </summary>
        FISH,

        /// <summary>
        /// fjord	a long, narrow, steep-walled, deep-water arm of the sea at high latitudes, usually along mountainous coasts
        /// </summary>
        FJD,

        /// <summary>
        /// fjords	long, narrow, steep-walled, deep-water arms of the sea at high latitudes, usually along mountainous coasts
        /// </summary>
        FJDS,

        /// <summary>
        /// waterfall(s)	a perpendicular or very steep descent of the water of a stream
        /// </summary>
        FLLS,

        /// <summary>
        /// section of waterfall(s)
        /// </summary>
        FLLSX,

        /// <summary>
        /// mud flat(s)	a relatively level area of mud either between high and low tide lines, or subject to flooding
        /// </summary>
        FLTM,

        /// <summary>
        /// tidal flat(s)	a large flat area of mud or sand attached to the shore and alternately covered and uncovered by the tide
        /// </summary>
        FLTT,

        /// <summary>
        /// glacier(s)	a mass of ice, usually at high latitudes or high elevations, with sufficient thickness to flow away from the source area in lobes, tongues, or masses
        /// </summary>
        GLCR,

        /// <summary>
        /// gulf	a large recess in the coastline, larger than a bay
        /// </summary>
        GULF,

        /// <summary>
        /// geyser	a type of hot spring with intermittent eruptions of jets of hot water and steam
        /// </summary>
        GYSR,

        /// <summary>
        /// harbor(s)	a haven or space of deep water so sheltered by the adjacent land as to afford a safe anchorage for ships
        /// </summary>
        HBR,

        /// <summary>
        /// section of harbor
        /// </summary>
        HBRX,

        /// <summary>
        /// inlet	a narrow waterway extending into the land, or connecting a bay or lagoon with a larger body of water
        /// </summary>
        INLT,

        /// <summary>
        /// former inlet	an inlet which has been filled in, or blocked by deposits
        /// </summary>
        INLTQ,

        /// <summary>
        /// lake bed(s)	a dried up or drained area of a former lake
        /// </summary>
        LBED,

        /// <summary>
        /// lagoon	a shallow coastal waterbody, completely or partly separated from a larger body of water by a barrier island, coral reef or other depositional feature
        /// </summary>
        LGN,

        /// <summary>
        /// lagoons	shallow coastal waterbodies, completely or partly separated from a larger body of water by a barrier island, coral reef or other depositional feature
        /// </summary>
        LGNS,

        /// <summary>
        /// section of lagoon
        /// </summary>
        LGNX,

        /// <summary>
        /// lake	a large inland body of standing water
        /// </summary>
        LK,

        /// <summary>
        /// crater lake	a lake in a crater or caldera
        /// </summary>
        LKC,

        /// <summary>
        /// intermittent lake
        /// </summary>
        LKI,

        /// <summary>
        /// salt lake	an inland body of salt water with no outlet
        /// </summary>
        LKN,

        /// <summary>
        /// intermittent salt lake
        /// </summary>
        LKNI,

        /// <summary>
        /// oxbow lake	a crescent-shaped lake commonly found adjacent to meandering streams
        /// </summary>
        LKO,

        /// <summary>
        /// intermittent oxbow lake
        /// </summary>
        LKOI,

        /// <summary>
        /// lakes	large inland bodies of standing water
        /// </summary>
        LKS,

        /// <summary>
        /// underground lake	a standing body of water in a cave
        /// </summary>
        LKSB,

        /// <summary>
        /// crater lakes	lakes in a crater or caldera
        /// </summary>
        LKSC,

        /// <summary>
        /// intermittent lakes
        /// </summary>
        LKSI,

        /// <summary>
        /// salt lakes	inland bodies of salt water with no outlet
        /// </summary>
        LKSN,

        /// <summary>
        /// intermittent salt lakes
        /// </summary>
        LKSNI,

        /// <summary>
        /// section of lake
        /// </summary>
        LKX,

        /// <summary>
        /// salt evaporation ponds	diked salt ponds used in the production of solar evaporated salt
        /// </summary>
        MFGN,

        /// <summary>
        /// mangrove swamp	a tropical tidal mud flat characterized by mangrove vegetation
        /// </summary>
        MGV,

        /// <summary>
        /// moor(s)	an area of open ground overlaid with wet peaty soils
        /// </summary>
        MOOR,

        /// <summary>
        /// marsh(es)	a wetland dominated by grass-like vegetation
        /// </summary>
        MRSH,

        /// <summary>
        /// salt marsh	a flat area, subject to periodic salt water inundation, dominated by grassy salt-tolerant plants
        /// </summary>
        MRSHN,

        /// <summary>
        /// narrows	a navigable narrow part of a bay, strait, river, etc.
        /// </summary>
        NRWS,

        /// <summary>
        /// ocean	one of the major divisions of the vast expanse of salt water covering part of the earth
        /// </summary>
        OCN,

        /// <summary>
        /// overfalls	an area of breaking waves caused by the meeting of currents or by waves moving against the current
        /// </summary>
        OVF,

        /// <summary>
        /// pond	a small standing waterbody
        /// </summary>
        PND,

        /// <summary>
        /// intermittent pond
        /// </summary>
        PNDI,

        /// <summary>
        /// salt pond	a small standing body of salt water often in a marsh or swamp, usually along a seacoast
        /// </summary>
        PNDN,

        /// <summary>
        /// intermittent salt pond(s)
        /// </summary>
        PNDNI,

        /// <summary>
        /// ponds	small standing waterbodies
        /// </summary>
        PNDS,

        /// <summary>
        /// fishponds	ponds or enclosures in which fish are kept or raised
        /// </summary>
        PNDSF,

        /// <summary>
        /// intermittent ponds
        /// </summary>
        PNDSI,

        /// <summary>
        /// salt ponds	small standing bodies of salt water often in a marsh or swamp, usually along a seacoast
        /// </summary>
        PNDSN,

        /// <summary>
        /// pool(s)	a small and comparatively still, deep part of a larger body of water such as a stream or harbor; or a small body of standing water
        /// </summary>
        POOL,

        /// <summary>
        /// intermittent pool
        /// </summary>
        POOLI,

        /// <summary>
        /// reach	a straight section of a navigable stream or channel between two bends
        /// </summary>
        RCH,

        /// <summary>
        /// icecap ridge	a linear elevation on an icecap
        /// </summary>
        RDGG,

        /// <summary>
        /// roadstead	an open anchorage affording less protection than a harbor
        /// </summary>
        RDST,

        /// <summary>
        /// reef(s)	a surface-navigation hazard composed of consolidated material
        /// </summary>
        RF,

        /// <summary>
        /// coral reef(s)	a surface-navigation hazard composed of coral
        /// </summary>
        RFC,

        /// <summary>
        /// section of reef
        /// </summary>
        RFX,

        /// <summary>
        /// rapids	a turbulent section of a stream associated with a steep, irregular stream bed
        /// </summary>
        RPDS,

        /// <summary>
        /// reservoir(s)	an artificial pond or lake
        /// </summary>
        RSV,

        /// <summary>
        /// intermittent reservoir
        /// </summary>
        RSVI,

        /// <summary>
        /// water tank	a contained pool or tank of water at, below, or above ground level
        /// </summary>
        RSVT,

        /// <summary>
        /// ravine(s)	a small, narrow, deep, steep-sided stream channel, smaller than a gorge
        /// </summary>
        RVN,

        /// <summary>
        /// sabkha(s)	a salt flat or salt encrusted plain subject to periodic inundation from flooding or high tides
        /// </summary>
        SBKH,

        /// <summary>
        /// sound	a long arm of the sea forming a channel between the mainland and an island or islands; or connecting two larger bodies of water
        /// </summary>
        SD,

        /// <summary>
        /// sea	a large body of salt water more or less confined by continuous land or chains of islands forming a subdivision of an ocean
        /// </summary>
        SEA,

        /// <summary>
        /// shoal(s)	a surface-navigation hazard composed of unconsolidated material
        /// </summary>
        SHOL,

        /// <summary>
        /// sill	the low part of an underwater gap or saddle separating basins, including a similar feature at the mouth of a fjord
        /// </summary>
        SILL,

        /// <summary>
        /// spring(s)	a place where ground water flows naturally out of the ground
        /// </summary>
        SPNG,

        /// <summary>
        /// sulphur spring(s)	a place where sulphur ground water flows naturally out of the ground
        /// </summary>
        SPNS,

        /// <summary>
        /// hot spring(s)	a place where hot ground water flows naturally out of the ground
        /// </summary>
        SPNT,

        /// <summary>
        /// stream	a body of running water moving to a lower level in a channel on land
        /// </summary>
        STM,

        /// <summary>
        /// anabranch	a diverging branch flowing out of a main stream and rejoining it downstream
        /// </summary>
        STMA,

        /// <summary>
        /// stream bend	a conspicuously curved or bent segment of a stream
        /// </summary>
        STMB,

        /// <summary>
        /// canalized stream	a stream that has been substantially ditched, diked, or straightened
        /// </summary>
        STMC,

        /// <summary>
        /// distributary(-ies)	a branch which flows away from the main stream, as in a delta or irrigation canal
        /// </summary>
        STMD,

        /// <summary>
        /// headwaters	the source and upper part of a stream, including the upper drainage basin
        /// </summary>
        STMH,

        /// <summary>
        /// intermittent stream
        /// </summary>
        STMI,

        /// <summary>
        /// section of intermittent stream
        /// </summary>
        STMIX,

        /// <summary>
        /// stream mouth(s)	a place where a stream discharges into a lagoon, lake, or the sea
        /// </summary>
        STMM,

        /// <summary>
        /// abandoned watercourse	a former stream or distributary no longer carrying flowing water, but still evident due to lakes, wetland, topographic or vegetation patterns
        /// </summary>
        STMQ,

        /// <summary>
        /// streams	bodies of running water moving to a lower level in a channel on land
        /// </summary>
        STMS,

        /// <summary>
        /// lost river	a surface stream that disappears into an underground channel, or dries up in an arid area
        /// </summary>
        STMSB,

        /// <summary>
        /// section of stream
        /// </summary>
        STMX,

        /// <summary>
        /// strait	a relatively narrow waterway, usually narrower and less extensive than a sound, connecting two larger bodies of water
        /// </summary>
        STRT,

        /// <summary>
        /// swamp	a wetland dominated by tree vegetation
        /// </summary>
        SWMP,

        /// <summary>
        /// irrigation system	a network of ditches and one or more of the following elements: water supply, reservoir, canal, pump, well, drain, etc.
        /// </summary>
        SYSI,

        /// <summary>
        /// canal tunnel	a tunnel through which a canal passes
        /// </summary>
        TNLC,

        /// <summary>
        /// wadi	a valley or ravine, bounded by relatively steep banks, which in the rainy season becomes a watercourse; found primarily in North Africa and the Middle East
        /// </summary>
        WAD,

        /// <summary>
        /// wadi bend	a conspicuously curved or bent segment of a wadi
        /// </summary>
        WADB,

        /// <summary>
        /// wadi junction	a place where two or more wadies join
        /// </summary>
        WADJ,

        /// <summary>
        /// wadi mouth	the lower terminus of a wadi where it widens into an adjoining floodplain, depression, or waterbody
        /// </summary>
        WADM,

        /// <summary>
        /// wadies	valleys or ravines, bounded by relatively steep banks, which in the rainy season become watercourses; found primarily in North Africa and the Middle East
        /// </summary>
        WADS,

        /// <summary>
        /// section of wadi
        /// </summary>
        WADX,

        /// <summary>
        /// whirlpool	a turbulent, rotating movement of water in a stream
        /// </summary>
        WHRL,

        /// <summary>
        /// well	a cylindrical hole, pit, or tunnel drilled or dug down to a depth from which water, oil, or gas can be pumped or brought to the surface
        /// </summary>
        WLL,

        /// <summary>
        /// abandoned well
        /// </summary>
        WLLQ,

        /// <summary>
        /// wells	cylindrical holes, pits, or tunnels drilled or dug down to a depth from which water, oil, or gas can be pumped or brought to the surface
        /// </summary>
        WLLS,

        /// <summary>
        /// wetland	an area subject to inundation, usually characterized by bog, marsh, or swamp vegetation
        /// </summary>
        WTLD,

        /// <summary>
        /// intermittent wetland
        /// </summary>
        WTLDI,

        /// <summary>
        /// watercourse	a natural, well-defined channel produced by flowing water, or an artificial channel designed to carry flowing water
        /// </summary>
        WTRC,

        /// <summary>
        /// waterhole(s)	a natural hole, hollow, or small depression that contains water, used by man and animals, especially in arid areas
        /// </summary>
        WTRH,
        
        /// <summary>
        /// agricultural colony	a tract of land set aside for agricultural settlement
        /// </summary>
        AGRC,

        /// <summary>
        /// amusement park	Amusement Park are theme parks, adventure parks offering entertainment, similar to funfairs but with a fix location
        /// </summary>
        AMUS,

        /// <summary>
        /// area	a tract of land without homogeneous character or boundaries
        /// </summary>
        AREA,

        /// <summary>
        /// drainage basin	an area drained by a stream
        /// </summary>
        BSND,

        /// <summary>
        /// petroleum basin	an area underlain by an oil-rich structural basin
        /// </summary>
        BSNP,

        /// <summary>
        /// battlefield	a site of a land battle of historical importance
        /// </summary>
        BTL,

        /// <summary>
        /// clearing	an area in a forest with trees removed
        /// </summary>
        CLG,

        /// <summary>
        /// common	a park or pasture for community use
        /// </summary>
        CMN,

        /// <summary>
        /// concession area	a lease of land by a government for economic development, e.g., mining, forestry
        /// </summary>
        CNS,

        /// <summary>
        /// coalfield	a region in which coal deposits of possible economic value occur
        /// </summary>
        COLF,

        /// <summary>
        /// continent	continent: Europe, Africa, Asia, North America, South America, Oceania, Antarctica
        /// </summary>
        CONT,

        /// <summary>
        /// coast	a zone of variable width straddling the shoreline
        /// </summary>
        CST,

        /// <summary>
        /// business center	a place where a number of businesses are located
        /// </summary>
        CTRB,

        /// <summary>
        /// housing development	a tract of land on which many houses of similar design are built according to a development plan
        /// </summary>
        DEVH,

        /// <summary>
        /// field(s)	an open as opposed to wooded area
        /// </summary>
        FLD,

        /// <summary>
        /// irrigated field(s)	a tract of level or terraced land which is irrigated
        /// </summary>
        FLDI,

        /// <summary>
        /// gasfield	an area containing a subterranean store of natural gas of economic value
        /// </summary>
        GASF,

        /// <summary>
        /// grazing area	an area of grasses and shrubs used for grazing
        /// </summary>
        GRAZ,

        /// <summary>
        /// gravel area	an area covered with gravel
        /// </summary>
        GVL,

        /// <summary>
        /// industrial area	an area characterized by industrial activity
        /// </summary>
        INDS,

        /// <summary>
        /// arctic land	a tract of land in the Arctic
        /// </summary>
        LAND,

        /// <summary>
        /// locality	a minor area or place of unspecified or mixed character and indefinite boundaries
        /// </summary>
        LCTY,

        /// <summary>
        /// military base	a place used by an army or other armed service for storing arms and supplies, and for accommodating and training troops, a base from which operations can be initiated
        /// </summary>
        MILB,

        /// <summary>
        /// mining area	an area of mine sites where minerals and ores are extracted
        /// </summary>
        MNA,

        /// <summary>
        /// maneuver area	a tract of land where military field exercises are carried out
        /// </summary>
        MVA,

        /// <summary>
        /// naval base	an area used to store supplies, provide barracks for troops and naval personnel, a port for naval vessels, and from which operations are initiated
        /// </summary>
        NVB,

        /// <summary>
        /// oasis(-es)	an area in a desert made productive by the availability of water
        /// </summary>
        OAS,

        /// <summary>
        /// oilfield	an area containing a subterranean store of petroleum of economic value
        /// </summary>
        OILF,

        /// <summary>
        /// peat cutting area	an area where peat is harvested
        /// </summary>
        PEAT,

        /// <summary>
        /// park	an area, often of forested land, maintained as a place of beauty, or for recreation
        /// </summary>
        PRK,

        /// <summary>
        /// port	a place provided with terminal and transfer facilities for loading and discharging waterborne cargo or passengers, usually located in a harbor
        /// </summary>
        PRT,

        /// <summary>
        /// quicksand	an area where loose sand with water moving through it may become unstable when heavy objects are placed at the surface, causing them to sink
        /// </summary>
        QCKS,

        /// <summary>
        /// reserve	a tract of public land reserved for future use or restricted as to use
        /// </summary>
        RES,

        /// <summary>
        /// agricultural reserve	a tract of land reserved for agricultural reclamation and/or development
        /// </summary>
        RESA,

        /// <summary>
        /// forest reserve	a forested area set aside for preservation or controlled use
        /// </summary>
        RESF,

        /// <summary>
        /// hunting reserve	a tract of land used primarily for hunting
        /// </summary>
        RESH,

        /// <summary>
        /// nature reserve	an area reserved for the maintenance of a natural habitat
        /// </summary>
        RESN,

        /// <summary>
        /// palm tree reserve	an area of palm trees where use is controlled
        /// </summary>
        RESP,

        /// <summary>
        /// reservation	a tract of land set aside for aboriginal, tribal, or native populations
        /// </summary>
        RESV,

        /// <summary>
        /// wildlife reserve	a tract of public land reserved for the preservation of wildlife
        /// </summary>
        RESW,

        /// <summary>
        /// region	an area distinguished by one or more observable physical or cultural characteristics
        /// </summary>
        RGN,

        /// <summary>
        /// economic region	a region of a country established for economic development or for statistical purposes
        /// </summary>
        RGNE,

        /// <summary>
        /// historical region	a former historic area distinguished by one or more observable physical or cultural characteristics
        /// </summary>
        RGNH,

        /// <summary>
        /// lake region	a tract of land distinguished by numerous lakes
        /// </summary>
        RGNL,

        /// <summary>
        /// artillery range	a tract of land used for artillery firing practice
        /// </summary>
        RNGA,

        /// <summary>
        /// salt area	a shallow basin or flat where salt accumulates after periodic inundation
        /// </summary>
        SALT,

        /// <summary>
        /// snowfield	an area of permanent snow and ice forming the accumulation area of a glacier
        /// </summary>
        SNOW,

        /// <summary>
        /// tribal area	a tract of land used by nomadic or other tribes
        /// </summary>
        TRB,
        
        /// <summary>
        /// populated place	a city, town, village, or other agglomeration of buildings where people live and work
        /// </summary>
        PPL,

        /// <summary>
        /// seat of a first-order administrative division	seat of a first-order administrative division (PPLC takes precedence over PPLA)
        /// </summary>
        PPLA,

        /// <summary>
        /// seat of a second-order administrative division
        /// </summary>
        PPLA2,

        /// <summary>
        /// seat of a third-order administrative division
        /// </summary>
        PPLA3,

        /// <summary>
        /// seat of a fourth-order administrative division
        /// </summary>
        PPLA4,

        /// <summary>
        /// capital of a political entity
        /// </summary>
        PPLC,

        /// <summary>
        /// historical capital of a political entity	a former capital of a political entity
        /// </summary>
        PPLCH,

        /// <summary>
        /// farm village	a populated place where the population is largely engaged in agricultural activities
        /// </summary>
        PPLF,

        /// <summary>
        /// seat of government of a political entity
        /// </summary>
        PPLG,

        /// <summary>
        /// historical populated place	a populated place that no longer exists
        /// </summary>
        PPLH,

        /// <summary>
        /// populated locality	an area similar to a locality but with a small group of dwellings or other buildings
        /// </summary>
        PPLL,

        /// <summary>
        /// abandoned populated place
        /// </summary>
        PPLQ,

        /// <summary>
        /// religious populated place	a populated place whose population is largely engaged in religious occupations
        /// </summary>
        PPLR,

        /// <summary>
        /// populated places	cities, towns, villages, or other agglomerations of buildings where people live and work
        /// </summary>
        PPLS,

        /// <summary>
        /// destroyed populated place	a village, town or city destroyed by a natural disaster, or by war
        /// </summary>
        PPLW,

        /// <summary>
        /// section of populated place
        /// </summary>
        PPLX,

        /// <summary>
        /// israeli settlement
        /// </summary>
        STLMT,

        /// <summary>
        /// causeway	a raised roadway across wet ground or shallow water
        /// </summary>
        CSWY,

        /// <summary>
        /// oil pipeline	a pipeline used for transporting oil
        /// </summary>
        OILP,

        /// <summary>
        /// promenade	a place for public walking, usually along a beach front
        /// </summary>
        PRMN,

        /// <summary>
        /// portage	a place where boats, goods, etc., are carried overland between navigable waters
        /// </summary>
        PTGE,

        /// <summary>
        /// road	an open way with improved surface for transportation of animals, people and vehicles
        /// </summary>
        RD,

        /// <summary>
        /// ancient road	the remains of a road used by ancient cultures
        /// </summary>
        RDA,

        /// <summary>
        /// road bend	a conspicuously curved or bent section of a road
        /// </summary>
        RDB,

        /// <summary>
        /// road cut	an excavation cut through a hill or ridge for a road
        /// </summary>
        RDCUT,

        /// <summary>
        /// road junction	a place where two or more roads join
        /// </summary>
        RDJCT,

        /// <summary>
        /// railroad junction	a place where two or more railroad tracks join
        /// </summary>
        RJCT,

        /// <summary>
        /// railroad	a permanent twin steel-rail track on which freight and passenger cars move long distances
        /// </summary>
        RR,

        /// <summary>
        /// abandoned railroad
        /// </summary>
        RRQ,

        /// <summary>
        /// caravan route	the route taken by caravans
        /// </summary>
        RTE,

        /// <summary>
        /// railroad yard	a system of tracks used for the making up of trains, and switching and storing freight cars
        /// </summary>
        RYD,

        /// <summary>
        /// street	a paved urban thoroughfare
        /// </summary>
        ST,

        /// <summary>
        /// stock route	a route taken by livestock herds
        /// </summary>
        STKR,

        /// <summary>
        /// tunnel	a subterranean passageway for transportation
        /// </summary>
        TNL,

        /// <summary>
        /// natural tunnel	a cave that is open at both ends
        /// </summary>
        TNLN,

        /// <summary>
        /// road tunnel	a tunnel through which a road passes
        /// </summary>
        TNLRD,

        /// <summary>
        /// railroad tunnel	a tunnel through which a railroad passes
        /// </summary>
        TNLRR,

        /// <summary>
        /// tunnels	subterranean passageways for transportation
        /// </summary>
        TNLS,

        /// <summary>
        /// trail	a path, track, or route used by pedestrians, animals, or off-road vehicles
        /// </summary>
        TRL,

        /// <summary>
        /// administrative facility	a government building
        /// </summary>
        ADMF,

        /// <summary>
        /// agricultural facility	a building and/or tract of land used for improving agriculture
        /// </summary>
        AGRF,

        /// <summary>
        /// airbase	an area used to store supplies, provide barracks for air force personnel, hangars and runways for aircraft, and from which operations are initiated
        /// </summary>
        AIRB,

        /// <summary>
        /// airfield	a place on land where aircraft land and take off; no facilities provided for the commercial handling of passengers and cargo
        /// </summary>
        AIRF,

        /// <summary>
        /// heliport	a place where helicopters land and take off
        /// </summary>
        AIRH,

        /// <summary>
        /// airport	a place where aircraft regularly land and take off, with runways, navigational aids, and major facilities for the commercial handling of passengers and cargo
        /// </summary>
        AIRP,

        /// <summary>
        /// abandoned airfield
        /// </summary>
        AIRQ,

        /// <summary>
        /// amphitheater	an oval or circular structure with rising tiers of seats about a stage or open space
        /// </summary>
        AMTH,

        /// <summary>
        /// ancient site	a place where archeological remains, old structures, or cultural artifacts are located
        /// </summary>
        ANS,

        /// <summary>
        /// aquaculture facility	facility or area for the cultivation of aquatic animals and plants, especially fish, shellfish, and seaweed, in natural or controlled marine or freshwater environments; underwater agriculture
        /// </summary>
        AQC,

        /// <summary>
        /// arch	a natural or man-made structure in the form of an arch
        /// </summary>
        ARCH,

        /// <summary>
        /// astronomical station	a point on the earth whose position has been determined by observations of celestial bodies
        /// </summary>
        ASTR,

        /// <summary>
        /// asylum	a facility where the insane are cared for and protected
        /// </summary>
        ASYL,

        /// <summary>
        /// athletic field	a tract of land used for playing team sports, and athletic track and field events
        /// </summary>
        ATHF,

        /// <summary>
        /// automatic teller machine	An unattended electronic machine in a public place, connected to a data system and related equipment and activated by a bank customer to obtain cash withdrawals and other banking services.
        /// </summary>
        ATM,

        /// <summary>
        /// bank	A business establishment in which money is kept for saving or commercial purposes or is invested, supplied for loans, or exchanged.
        /// </summary>
        BANK,

        /// <summary>
        /// beacon	a fixed artificial navigation mark
        /// </summary>
        BCN,

        /// <summary>
        /// bridge	a structure erected across an obstacle such as a stream, road, etc., in order to carry roads, railroads, and pedestrians across
        /// </summary>
        BDG,

        /// <summary>
        /// ruined bridge	a destroyed or decayed bridge which is no longer functional
        /// </summary>
        BDGQ,

        /// <summary>
        /// building(s)	a structure built for permanent use, as a house, factory, etc.
        /// </summary>
        BLDG,

        /// <summary>
        /// office building	commercial building where business and/or services are conducted
        /// </summary>
        BLDO,

        /// <summary>
        /// boundary marker	a fixture marking a point along a boundary
        /// </summary>
        BP,

        /// <summary>
        /// barracks	a building for lodging military personnel
        /// </summary>
        BRKS,

        /// <summary>
        /// breakwater	a structure erected to break the force of waves at the entrance to a harbor or port
        /// </summary>
        BRKW,

        /// <summary>
        /// baling station	a facility for baling agricultural products
        /// </summary>
        BSTN,

        /// <summary>
        /// boatyard	a waterside facility for servicing, repairing, and building small vessels
        /// </summary>
        BTYD,

        /// <summary>
        /// burial cave(s)	a cave used for human burials
        /// </summary>
        BUR,

        /// <summary>
        /// bus station	a facility comprising ticket office, platforms, etc. for loading and unloading passengers
        /// </summary>
        BUSTN,

        /// <summary>
        /// bus stop	a place lacking station facilities
        /// </summary>
        BUSTP,

        /// <summary>
        /// cairn	a heap of stones erected as a landmark or for other purposes
        /// </summary>
        CARN,

        /// <summary>
        /// cave(s)	an underground passageway or chamber, or cavity on the side of a cliff
        /// </summary>
        CAVE,

        /// <summary>
        /// church	a building for public Christian worship
        /// </summary>
        CH,

        /// <summary>
        /// camp(s)	a site occupied by tents, huts, or other shelters for temporary use
        /// </summary>
        CMP,

        /// <summary>
        /// logging camp	a camp used by loggers
        /// </summary>
        CMPL,

        /// <summary>
        /// labor camp	a camp used by migrant or temporary laborers
        /// </summary>
        CMPLA,

        /// <summary>
        /// mining camp	a camp used by miners
        /// </summary>
        CMPMN,

        /// <summary>
        /// oil camp	a camp used by oilfield workers
        /// </summary>
        CMPO,

        /// <summary>
        /// abandoned camp
        /// </summary>
        CMPQ,

        /// <summary>
        /// refugee camp	a camp used by refugees
        /// </summary>
        CMPRF,

        /// <summary>
        /// cemetery	a burial place or ground
        /// </summary>
        CMTY,

        /// <summary>
        /// communication center	a facility, including buildings, antennae, towers and electronic equipment for receiving and transmitting information
        /// </summary>
        COMC,

        /// <summary>
        /// corral(s)	a pen or enclosure for confining or capturing animals
        /// </summary>
        CRRL,

        /// <summary>
        /// casino	a building used for entertainment, especially gambling
        /// </summary>
        CSNO,

        /// <summary>
        /// castle	a large fortified building or set of buildings
        /// </summary>
        CSTL,

        /// <summary>
        /// customs house	a building in a port where customs and duties are paid, and where vessels are entered and cleared
        /// </summary>
        CSTM,

        /// <summary>
        /// courthouse	a building in which courts of law are held
        /// </summary>
        CTHSE,

        /// <summary>
        /// atomic center	a facility where atomic research is carried out
        /// </summary>
        CTRA,

        /// <summary>
        /// community center	a facility for community recreation and other activities
        /// </summary>
        CTRCM,

        /// <summary>
        /// facility center	a place where more than one facility is situated
        /// </summary>
        CTRF,

        /// <summary>
        /// medical center	a complex of health care buildings including two or more of the following: hospital, medical school, clinic, pharmacy, doctor's offices, etc.
        /// </summary>
        CTRM,

        /// <summary>
        /// religious center	a facility where more than one religious activity is carried out, e.g., retreat, school, monastery, worship
        /// </summary>
        CTRR,

        /// <summary>
        /// space center	a facility for launching, tracking, or controlling satellites and space vehicles
        /// </summary>
        CTRS,

        /// <summary>
        /// convent	a building where a community of nuns lives in seclusion
        /// </summary>
        CVNT,

        /// <summary>
        /// dam	a barrier constructed across a stream to impound water
        /// </summary>
        DAM,

        /// <summary>
        /// ruined dam	a destroyed or decayed dam which is no longer functional
        /// </summary>
        DAMQ,

        /// <summary>
        /// sub-surface dam	a dam put down to bedrock in a sand river
        /// </summary>
        DAMSB,

        /// <summary>
        /// dairy	a facility for the processing, sale and distribution of milk or milk products
        /// </summary>
        DARY,

        /// <summary>
        /// dry dock	a dock providing support for a vessel, and means for removing the water so that the bottom of the vessel can be exposed
        /// </summary>
        DCKD,

        /// <summary>
        /// dockyard	a facility for servicing, building, or repairing ships
        /// </summary>
        DCKY,

        /// <summary>
        /// dike	an earth or stone embankment usually constructed for flood or stream control
        /// </summary>
        DIKE,

        /// <summary>
        /// diplomatic facility	office, residence, or facility of a foreign government, which may include an embassy, consulate, chancery, office of charge d'affaires, or other diplomatic, economic, military, or cultural mission
        /// </summary>
        DIP,

        /// <summary>
        /// fuel depot	an area where fuel is stored
        /// </summary>
        DPOF,

        /// <summary>
        /// estate(s)	a large commercialized agricultural landholding with associated buildings and other facilities
        /// </summary>
        EST,

        /// <summary>
        /// oil palm plantation	an estate specializing in the cultivation of oil palm trees
        /// </summary>
        ESTO,

        /// <summary>
        /// rubber plantation	an estate which specializes in growing and tapping rubber trees
        /// </summary>
        ESTR,

        /// <summary>
        /// sugar plantation	an estate that specializes in growing sugar cane
        /// </summary>
        ESTSG,

        /// <summary>
        /// tea plantation	an estate which specializes in growing tea bushes
        /// </summary>
        ESTT,

        /// <summary>
        /// section of estate
        /// </summary>
        ESTX,

        /// <summary>
        /// facility	a building or buildings housing a center, institute, foundation, hospital, prison, mission, courthouse, etc.
        /// </summary>
        FCL,

        /// <summary>
        /// foundry	a building or works where metal casting is carried out
        /// </summary>
        FNDY,

        /// <summary>
        /// farm	a tract of land with associated buildings devoted to agriculture
        /// </summary>
        FRM,

        /// <summary>
        /// abandoned farm
        /// </summary>
        FRMQ,

        /// <summary>
        /// farms	tracts of land with associated buildings devoted to agriculture
        /// </summary>
        FRMS,

        /// <summary>
        /// farmstead	the buildings and adjacent service areas of a farm
        /// </summary>
        FRMT,

        /// <summary>
        /// fort	a defensive structure or earthworks
        /// </summary>
        FT,

        /// <summary>
        /// ferry	a boat or other floating conveyance and terminal facilities regularly used to transport people and vehicles across a waterbody
        /// </summary>
        FY,

        /// <summary>
        /// gate	a controlled access entrance or exit
        /// </summary>
        GATE,

        /// <summary>
        /// garden(s)	an enclosure for displaying selected plant or animal life
        /// </summary>
        GDN,

        /// <summary>
        /// ghat	a set of steps leading to a river, which are of religious significance, and at their base is usually a platform for bathing
        /// </summary>
        GHAT,

        /// <summary>
        /// guest house	a house used to provide lodging for paying guests
        /// </summary>
        GHSE,

        /// <summary>
        /// gas-oil separator plant	a facility for separating gas from oil
        /// </summary>
        GOSP,

        /// <summary>
        /// local government office	a facility housing local governmental offices, usually a city, town, or village hall
        /// </summary>
        GOVL,

        /// <summary>
        /// grave	a burial site
        /// </summary>
        GRVE,

        /// <summary>
        /// hermitage	a secluded residence, usually for religious sects
        /// </summary>
        HERM,

        /// <summary>
        /// halting place	a place where caravans stop for rest
        /// </summary>
        HLT,

        /// <summary>
        /// homestead	a residence, owner's or manager's, on a sheep or cattle station, woolshed, outcamp, or Aboriginal outstation, specific to Australia and New Zealand
        /// </summary>
        HMSD,

        /// <summary>
        /// house(s)	a building used as a human habitation
        /// </summary>
        HSE,

        /// <summary>
        /// country house	a large house, mansion, or chateau, on a large estate
        /// </summary>
        HSEC,

        /// <summary>
        /// hospital	a building in which sick or injured, especially those confined to bed, are medically treated
        /// </summary>
        HSP,

        /// <summary>
        /// clinic	a medical facility associated with a hospital for outpatients
        /// </summary>
        HSPC,

        /// <summary>
        /// dispensary	a building where medical or dental aid is dispensed
        /// </summary>
        HSPD,

        /// <summary>
        /// leprosarium	an asylum or hospital for lepers
        /// </summary>
        HSPL,

        /// <summary>
        /// historical site	a place of historical importance
        /// </summary>
        HSTS,

        /// <summary>
        /// hotel	a building providing lodging and/or meals for the public
        /// </summary>
        HTL,

        /// <summary>
        /// hut	a small primitive house
        /// </summary>
        HUT,

        /// <summary>
        /// huts	small primitive houses
        /// </summary>
        HUTS,

        /// <summary>
        /// military installation	a facility for use of and control by armed forces
        /// </summary>
        INSM,

        /// <summary>
        /// research institute	a facility where research is carried out
        /// </summary>
        ITTR,

        /// <summary>
        /// jetty	a structure built out into the water at a river mouth or harbor entrance to regulate currents and silting
        /// </summary>
        JTY,

        /// <summary>
        /// landing	a place where boats receive or discharge passengers and freight, but lacking most port facilities
        /// </summary>
        LDNG,

        /// <summary>
        /// leper colony	a settled area inhabited by lepers in relative isolation
        /// </summary>
        LEPC,

        /// <summary>
        /// library	A place in which information resources such as books are kept for reading, reference, or lending.
        /// </summary>
        LIBR,

        /// <summary>
        /// landfill	a place for trash and garbage disposal in which the waste is buried between layers of earth to build up low-lying land
        /// </summary>
        LNDF,

        /// <summary>
        /// lock(s)	a basin in a waterway with gates at each end by means of which vessels are passed from one water level to another
        /// </summary>
        LOCK,

        /// <summary>
        /// lighthouse	a distinctive structure exhibiting a major navigation light
        /// </summary>
        LTHSE,

        /// <summary>
        /// mall	A large, often enclosed shopping complex containing various stores, businesses, and restaurants usually accessible by common passageways.
        /// </summary>
        MALL,

        /// <summary>
        /// marina	a harbor facility for small boats, yachts, etc.
        /// </summary>
        MAR,

        /// <summary>
        /// factory	one or more buildings where goods are manufactured, processed or fabricated
        /// </summary>
        MFG,

        /// <summary>
        /// brewery	one or more buildings where beer is brewed
        /// </summary>
        MFGB,

        /// <summary>
        /// cannery	a building where food items are canned
        /// </summary>
        MFGC,

        /// <summary>
        /// copper works	a facility for processing copper ore
        /// </summary>
        MFGCU,

        /// <summary>
        /// limekiln	a furnace in which limestone is reduced to lime
        /// </summary>
        MFGLM,

        /// <summary>
        /// munitions plant	a factory where ammunition is made
        /// </summary>
        MFGM,

        /// <summary>
        /// phosphate works	a facility for producing fertilizer
        /// </summary>
        MFGPH,

        /// <summary>
        /// abandoned factory
        /// </summary>
        MFGQ,

        /// <summary>
        /// sugar refinery	a facility for converting raw sugar into refined sugar
        /// </summary>
        MFGSG,

        /// <summary>
        /// market	a place where goods are bought and sold at regular intervals
        /// </summary>
        MKT,

        /// <summary>
        /// mill(s)	a building housing machines for transforming, shaping, finishing, grinding, or extracting products
        /// </summary>
        ML,

        /// <summary>
        /// ore treatment plant	a facility for improving the metal content of ore by concentration
        /// </summary>
        MLM,

        /// <summary>
        /// olive oil mill	a mill where oil is extracted from olives
        /// </summary>
        MLO,

        /// <summary>
        /// sugar mill	a facility where sugar cane is processed into raw sugar
        /// </summary>
        MLSG,

        /// <summary>
        /// former sugar mill	a sugar mill no longer used as a sugar mill
        /// </summary>
        MLSGQ,

        /// <summary>
        /// sawmill	a mill where logs or lumber are sawn to specified shapes and sizes
        /// </summary>
        MLSW,

        /// <summary>
        /// windmill	a mill or water pump powered by wind
        /// </summary>
        MLWND,

        /// <summary>
        /// water mill	a mill powered by running water
        /// </summary>
        MLWTR,

        /// <summary>
        /// mine(s)	a site where mineral ores are extracted from the ground by excavating surface pits and subterranean passages
        /// </summary>
        MN,

        /// <summary>
        /// gold mine(s)	a mine where gold ore, or alluvial gold is extracted
        /// </summary>
        MNAU,

        /// <summary>
        /// coal mine(s)	a mine where coal is extracted
        /// </summary>
        MNC,

        /// <summary>
        /// chrome mine(s)	a mine where chrome ore is extracted
        /// </summary>
        MNCR,

        /// <summary>
        /// copper mine(s)	a mine where copper ore is extracted
        /// </summary>
        MNCU,

        /// <summary>
        /// iron mine(s)	a mine where iron ore is extracted
        /// </summary>
        MNFE,

        /// <summary>
        /// monument	a commemorative structure or statue
        /// </summary>
        MNMT,

        /// <summary>
        /// salt mine(s)	a mine from which salt is extracted
        /// </summary>
        MNN,

        /// <summary>
        /// abandoned mine
        /// </summary>
        MNQ,

        /// <summary>
        /// quarry(-ies)	a surface mine where building stone or gravel and sand, etc. are extracted
        /// </summary>
        MNQR,

        /// <summary>
        /// mole	a massive structure of masonry or large stones serving as a pier or breakwater
        /// </summary>
        MOLE,

        /// <summary>
        /// mosque	a building for public Islamic worship
        /// </summary>
        MSQE,

        /// <summary>
        /// mission	a place characterized by dwellings, school, church, hospital and other facilities operated by a religious group for the purpose of providing charitable services and to propagate religion
        /// </summary>
        MSSN,

        /// <summary>
        /// abandoned mission
        /// </summary>
        MSSNQ,

        /// <summary>
        /// monastery	a building and grounds where a community of monks lives in seclusion
        /// </summary>
        MSTY,

        /// <summary>
        /// metro station	metro station (Underground, Tube, or Metro)
        /// </summary>
        MTRO,

        /// <summary>
        /// museum	a building where objects of permanent interest in one or more of the arts and sciences are preserved and exhibited
        /// </summary>
        MUS,

        /// <summary>
        /// novitiate	a religious house or school where novices are trained
        /// </summary>
        NOV,

        /// <summary>
        /// nursery(-ies)	a place where plants are propagated for transplanting or grafting
        /// </summary>
        NSY,

        /// <summary>
        /// observation point	a wildlife or scenic observation point
        /// </summary>
        OBPT,

        /// <summary>
        /// observatory	a facility equipped for observation of atmospheric or space phenomena
        /// </summary>
        OBS,

        /// <summary>
        /// radio observatory	a facility equipped with an array of antennae for receiving radio waves from space
        /// </summary>
        OBSR,

        /// <summary>
        /// oil pipeline junction	a section of an oil pipeline where two or more pipes join together
        /// </summary>
        OILJ,

        /// <summary>
        /// abandoned oil well
        /// </summary>
        OILQ,

        /// <summary>
        /// oil refinery	a facility for converting crude oil into refined petroleum products
        /// </summary>
        OILR,

        /// <summary>
        /// tank farm	a tract of land occupied by large, cylindrical, metal tanks in which oil or liquid petrochemicals are stored
        /// </summary>
        OILT,

        /// <summary>
        /// oil well	a well from which oil may be pumped
        /// </summary>
        OILW,

        /// <summary>
        /// opera house	A theater designed chiefly for the performance of operas.
        /// </summary>
        OPRA,

        /// <summary>
        /// palace	a large stately house, often a royal or presidential residence
        /// </summary>
        PAL,

        /// <summary>
        /// pagoda	a tower-like storied structure, usually a Buddhist shrine
        /// </summary>
        PGDA,

        /// <summary>
        /// pier	a structure built out into navigable water on piles providing berthing for ships and recreation
        /// </summary>
        PIER,

        /// <summary>
        /// parking lot	an area used for parking vehicles
        /// </summary>
        PKLT,

        /// <summary>
        /// oil pumping station	a facility for pumping oil through a pipeline
        /// </summary>
        PMPO,

        /// <summary>
        /// water pumping station	a facility for pumping water from a major well or through a pipeline
        /// </summary>
        PMPW,

        /// <summary>
        /// post office	a public building in which mail is received, sorted and distributed
        /// </summary>
        PO,

        /// <summary>
        /// police post	a building in which police are stationed
        /// </summary>
        PP,

        /// <summary>
        /// abandoned police post
        /// </summary>
        PPQ,

        /// <summary>
        /// park gate	a controlled access to a park
        /// </summary>
        PRKGT,

        /// <summary>
        /// park headquarters	a park administrative facility
        /// </summary>
        PRKHQ,

        /// <summary>
        /// prison	a facility for confining prisoners
        /// </summary>
        PRN,

        /// <summary>
        /// reformatory	a facility for confining, training, and reforming young law offenders
        /// </summary>
        PRNJ,

        /// <summary>
        /// abandoned prison
        /// </summary>
        PRNQ,

        /// <summary>
        /// power station	a facility for generating electric power
        /// </summary>
        PS,

        /// <summary>
        /// hydroelectric power station	a building where electricity is generated from water power
        /// </summary>
        PSH,

        /// <summary>
        /// border post	a post or station at an international boundary for the regulation of movement of people and goods
        /// </summary>
        PSTB,

        /// <summary>
        /// customs post	a building at an international boundary where customs and duties are paid on goods
        /// </summary>
        PSTC,

        /// <summary>
        /// patrol post	a post from which patrols are sent out
        /// </summary>
        PSTP,

        /// <summary>
        /// pyramid	an ancient massive structure of square ground plan with four triangular faces meeting at a point and used for enclosing tombs
        /// </summary>
        PYR,

        /// <summary>
        /// pyramids	ancient massive structures of square ground plan with four triangular faces meeting at a point and used for enclosing tombs
        /// </summary>
        PYRS,

        /// <summary>
        /// quay	a structure of solid construction along a shore or bank which provides berthing for ships and which generally provides cargo handling facilities
        /// </summary>
        QUAY,

        /// <summary>
        /// traffic circle	a road junction formed around a central circle about which traffic moves in one direction only
        /// </summary>
        RDCR,

        /// <summary>
        /// golf course	a recreation field where golf is played
        /// </summary>
        RECG,

        /// <summary>
        /// racetrack	a track where races are held
        /// </summary>
        RECR,

        /// <summary>
        /// restaurant	A place where meals are served to the public
        /// </summary>
        REST,

        /// <summary>
        /// store	a building where goods and/or services are offered for sale
        /// </summary>
        RET,

        /// <summary>
        /// resthouse	a structure maintained for the rest and shelter of travelers
        /// </summary>
        RHSE,

        /// <summary>
        /// rookery	a breeding place of a colony of birds or seals
        /// </summary>
        RKRY,

        /// <summary>
        /// religious site	an ancient site of significant religious importance
        /// </summary>
        RLG,

        /// <summary>
        /// retreat	a place of temporary seclusion, especially for religious groups
        /// </summary>
        RLGR,

        /// <summary>
        /// ranch(es)	a large farm specializing in extensive grazing of livestock
        /// </summary>
        RNCH,

        /// <summary>
        /// railroad siding	a short track parallel to and joining the main track
        /// </summary>
        RSD,

        /// <summary>
        /// railroad signal	a signal at the entrance of a particular section of track governing the movement of trains
        /// </summary>
        RSGNL,

        /// <summary>
        /// resort	a specialized facility for vacation, health, or participation sports activities
        /// </summary>
        RSRT,

        /// <summary>
        /// railroad station	a facility comprising ticket office, platforms, etc. for loading and unloading train passengers and freight
        /// </summary>
        RSTN,

        /// <summary>
        /// abandoned railroad station
        /// </summary>
        RSTNQ,

        /// <summary>
        /// railroad stop	a place lacking station facilities where trains stop to pick up and unload passengers and freight
        /// </summary>
        RSTP,

        /// <summary>
        /// abandoned railroad stop
        /// </summary>
        RSTPQ,

        /// <summary>
        /// ruin(s)	a destroyed or decayed structure which is no longer functional
        /// </summary>
        RUIN,

        /// <summary>
        /// school	building(s) where instruction in one or more branches of knowledge takes place
        /// </summary>
        SCH,

        /// <summary>
        /// agricultural school	a school with a curriculum focused on agriculture
        /// </summary>
        SCHA,

        /// <summary>
        /// college	the grounds and buildings of an institution of higher learning
        /// </summary>
        SCHC,

        /// <summary>
        /// language school	Language Schools & Institutions
        /// </summary>
        SCHL,

        /// <summary>
        /// military school	a school at which military science forms the core of the curriculum
        /// </summary>
        SCHM,

        /// <summary>
        /// maritime school	a school at which maritime sciences form the core of the curriculum
        /// </summary>
        SCHN,

        /// <summary>
        /// technical school	post-secondary school with a specifically technical or vocational curriculum
        /// </summary>
        SCHT,

        /// <summary>
        /// State Exam Prep Centre	state exam preparation centres
        /// </summary>
        SECP,

        /// <summary>
        /// sheepfold	a fence or wall enclosure for sheep and other small herd animals
        /// </summary>
        SHPF,

        /// <summary>
        /// shrine	a structure or place memorializing a person or religious concept
        /// </summary>
        SHRN,

        /// <summary>
        /// storehouse	a building for storing goods, especially provisions
        /// </summary>
        SHSE,

        /// <summary>
        /// sluice	a conduit or passage for carrying off surplus water from a waterbody, usually regulated by means of a sluice gate
        /// </summary>
        SLCE,

        /// <summary>
        /// sanatorium	a facility where victims of physical or mental disorders are treated
        /// </summary>
        SNTR,

        /// <summary>
        /// spa	a resort area usually developed around a medicinal spring
        /// </summary>
        SPA,

        /// <summary>
        /// spillway	a passage or outlet through which surplus water flows over, around or through a dam
        /// </summary>
        SPLY,

        /// <summary>
        /// square	a broad, open, public area near the center of a town or city
        /// </summary>
        SQR,

        /// <summary>
        /// stable	a building for the shelter and feeding of farm animals, especially horses
        /// </summary>
        STBL,

        /// <summary>
        /// stadium	a structure with an enclosure for athletic games with tiers of seats for spectators
        /// </summary>
        STDM,

        /// <summary>
        /// scientific research base	a scientific facility used as a base from which research is carried out or monitored
        /// </summary>
        STNB,

        /// <summary>
        /// coast guard station	a facility from which the coast is guarded by armed vessels
        /// </summary>
        STNC,

        /// <summary>
        /// experiment station	a facility for carrying out experiments
        /// </summary>
        STNE,

        /// <summary>
        /// forest station	a collection of buildings and facilities for carrying out forest management
        /// </summary>
        STNF,

        /// <summary>
        /// inspection station	a station at which vehicles, goods, and people are inspected
        /// </summary>
        STNI,

        /// <summary>
        /// meteorological station	a station at which weather elements are recorded
        /// </summary>
        STNM,

        /// <summary>
        /// radio station	a facility for producing and transmitting information by radio waves
        /// </summary>
        STNR,

        /// <summary>
        /// satellite station	a facility for tracking and communicating with orbiting satellites
        /// </summary>
        STNS,

        /// <summary>
        /// whaling station	a facility for butchering whales and processing train oil
        /// </summary>
        STNW,

        /// <summary>
        /// steps	stones or slabs placed for ease in ascending or descending a steep slope
        /// </summary>
        STPS,

        /// <summary>
        /// sewage treatment plant	facility for the processing of sewage and/or wastewater
        /// </summary>
        SWT,

        /// <summary>
        /// theater	A building, room, or outdoor structure for the presentation of plays, films, or other dramatic performances
        /// </summary>
        THTR,

        /// <summary>
        /// tomb(s)	a structure for interring bodies
        /// </summary>
        TMB,

        /// <summary>
        /// temple(s)	an edifice dedicated to religious worship
        /// </summary>
        TMPL,

        /// <summary>
        /// cattle dipping tank	a small artificial pond used for immersing cattle in chemically treated water for disease control
        /// </summary>
        TNKD,

        /// <summary>
        /// tower	a high conspicuous structure, typically much higher than its diameter
        /// </summary>
        TOWR,

        /// <summary>
        /// transit terminal	facilities for the handling of vehicular freight and passengers
        /// </summary>
        TRANT,

        /// <summary>
        /// triangulation station	a point on the earth whose position has been determined by triangulation
        /// </summary>
        TRIG,

        /// <summary>
        /// oil pipeline terminal	a tank farm or loading facility at the end of an oil pipeline
        /// </summary>
        TRMO,

        /// <summary>
        /// temp work office	Temporary Work Offices
        /// </summary>
        TWO,

        /// <summary>
        /// university prep school	University Preparation Schools & Institutions
        /// </summary>
        UNIP,

        /// <summary>
        /// university	An institution for higher learning with teaching and research facilities constituting a graduate school and professional schools that award master's degrees and doctorates and an undergraduate division that awards bachelor's degrees.
        /// </summary>
        UNIV,

        /// <summary>
        /// united states government establishment	a facility operated by the United States Government in Panama
        /// </summary>
        USGE,

        /// <summary>
        /// veterinary facility	a building or camp at which veterinary services are available
        /// </summary>
        VETF,

        /// <summary>
        /// wall	a thick masonry structure, usually enclosing a field or building, or forming the side of a structure
        /// </summary>
        WALL,

        /// <summary>
        /// ancient wall	the remains of a linear defensive stone structure
        /// </summary>
        WALLA,

        /// <summary>
        /// weir(s)	a small dam in a stream, designed to raise the water level or to divert stream flow through a desired channel
        /// </summary>
        WEIR,

        /// <summary>
        /// wharf(-ves)	a structure of open rather than solid construction along a shore or a bank which provides berthing for ships and cargo-handling facilities
        /// </summary>
        WHRF,

        /// <summary>
        /// wreck	the site of the remains of a wrecked vessel
        /// </summary>
        WRCK,

        /// <summary>
        /// waterworks	a facility for supplying potable water through a water source and a system of pumps and filtration beds
        /// </summary>
        WTRW,

        /// <summary>
        /// free trade zone	an area, usually a section of a port, where goods may be received and shipped free of customs duty and of most customs regulations
        /// </summary>
        ZNF,

        /// <summary>
        /// zoo	a zoological garden or park where wild animals are kept for exhibition
        /// </summary>
        ZOO,

        /// <summary>
        /// asphalt lake	a small basin containing naturally occurring asphalt
        /// </summary>
        ASPH,

        /// <summary>
        /// atoll(s)	a ring-shaped coral reef which has closely spaced islands on it encircling a lagoon
        /// </summary>
        ATOL,

        /// <summary>
        /// bar	a shallow ridge or mound of coarse unconsolidated material in a stream channel, at the mouth of a stream, estuary, or lagoon and in the wave-break zone along coasts
        /// </summary>
        BAR,

        /// <summary>
        /// beach	a shore zone of coarse unconsolidated sediment that extends from the low-water line to the highest reach of storm waves
        /// </summary>
        BCH,

        /// <summary>
        /// beaches	a shore zone of coarse unconsolidated sediment that extends from the low-water line to the highest reach of storm waves
        /// </summary>
        BCHS,

        /// <summary>
        /// badlands	an area characterized by a maze of very closely spaced, deep, narrow, steep-sided ravines, and sharp crests and pinnacles
        /// </summary>
        BDLD,

        /// <summary>
        /// boulder field	a high altitude or high latitude bare, flat area covered with large angular rocks
        /// </summary>
        BLDR,

        /// <summary>
        /// blowhole(s)	a hole in coastal rock through which sea water is forced by a rising tide or waves and spurted through an outlet into the air
        /// </summary>
        BLHL,

        /// <summary>
        /// blowout(s)	a small depression in sandy terrain, caused by wind erosion
        /// </summary>
        BLOW,

        /// <summary>
        /// bench	a long, narrow bedrock platform bounded by steeper slopes above and below, usually overlooking a waterbody
        /// </summary>
        BNCH,

        /// <summary>
        /// butte(s)	a small, isolated, usually flat-topped hill with steep sides
        /// </summary>
        BUTE,

        /// <summary>
        /// cape	a land area, more prominent than a point, projecting into the sea and marking a notable change in coastal direction
        /// </summary>
        CAPE,

        /// <summary>
        /// cleft(s)	a deep narrow slot, notch, or groove in a coastal cliff
        /// </summary>
        CFT,

        /// <summary>
        /// caldera	a depression measuring kilometers across formed by the collapse of a volcanic mountain
        /// </summary>
        CLDA,

        /// <summary>
        /// cliff(s)	a high, steep to perpendicular slope overlooking a waterbody or lower area
        /// </summary>
        CLF,

        /// <summary>
        /// canyon	a deep, narrow valley with steep sides cutting into a plateau or mountainous area
        /// </summary>
        CNYN,

        /// <summary>
        /// cone(s)	a conical landform composed of mud or volcanic material
        /// </summary>
        CONE,

        /// <summary>
        /// corridor	a strip or area of land having significance as an access way
        /// </summary>
        CRDR,

        /// <summary>
        /// cirque	a bowl-like hollow partially surrounded by cliffs or steep slopes at the head of a glaciated valley
        /// </summary>
        CRQ,

        /// <summary>
        /// cirques	bowl-like hollows partially surrounded by cliffs or steep slopes at the head of a glaciated valley
        /// </summary>
        CRQS,

        /// <summary>
        /// crater(s)	a generally circular saucer or bowl-shaped depression caused by volcanic or meteorite explosive action
        /// </summary>
        CRTR,

        /// <summary>
        /// cuesta(s)	an asymmetric ridge formed on tilted strata
        /// </summary>
        CUET,

        /// <summary>
        /// delta	a flat plain formed by alluvial deposits at the mouth of a stream
        /// </summary>
        DLTA,

        /// <summary>
        /// depression(s)	a low area surrounded by higher land and usually characterized by interior drainage
        /// </summary>
        DPR,

        /// <summary>
        /// desert	a large area with little or no vegetation due to extreme environmental conditions
        /// </summary>
        DSRT,

        /// <summary>
        /// dune(s)	a wave form, ridge or star shape feature composed of sand
        /// </summary>
        DUNE,

        /// <summary>
        /// divide	a line separating adjacent drainage basins
        /// </summary>
        DVD,

        /// <summary>
        /// sandy desert	an extensive tract of shifting sand and sand dunes
        /// </summary>
        ERG,

        /// <summary>
        /// fan(s)	a fan-shaped wedge of coarse alluvium with apex merging with a mountain stream bed and the fan spreading out at a low angle slope onto an adjacent plain
        /// </summary>
        FAN,

        /// <summary>
        /// ford	a shallow part of a stream which can be crossed on foot or by land vehicle
        /// </summary>
        FORD,

        /// <summary>
        /// fissure	a crack associated with volcanism
        /// </summary>
        FSR,

        /// <summary>
        /// gap	a low place in a ridge, not used for transportation
        /// </summary>
        GAP,

        /// <summary>
        /// gorge(s)	a short, narrow, steep-sided section of a stream valley
        /// </summary>
        GRGE,

        /// <summary>
        /// headland	a high projection of land extending into a large body of water beyond the line of the coast
        /// </summary>
        HDLD,

        /// <summary>
        /// hill	a rounded elevation of limited extent rising above the surrounding land with local relief of less than 300m
        /// </summary>
        HLL,

        /// <summary>
        /// hills	rounded elevations of limited extent rising above the surrounding land with local relief of less than 300m
        /// </summary>
        HLLS,

        /// <summary>
        /// hammock(s)	a patch of ground, distinct from and slightly above the surrounding plain or wetland. Often occurs in groups
        /// </summary>
        HMCK,

        /// <summary>
        /// rock desert	a relatively sand-free, high bedrock plateau in a hot desert, with or without a gravel veneer
        /// </summary>
        HMDA,

        /// <summary>
        /// interfluve	a relatively undissected upland between adjacent stream valleys
        /// </summary>
        INTF,

        /// <summary>
        /// island	a tract of land, smaller than a continent, surrounded by water at high water
        /// </summary>
        ISL,

        /// <summary>
        /// islet	small island, bigger than rock, smaller than island.
        /// </summary>
        ISLET,

        /// <summary>
        /// artificial island	an island created by landfill or diking and filling in a wetland, bay, or lagoon
        /// </summary>
        ISLF,

        /// <summary>
        /// mangrove island	a mangrove swamp surrounded by a waterbody
        /// </summary>
        ISLM,

        /// <summary>
        /// islands	tracts of land, smaller than a continent, surrounded by water at high water
        /// </summary>
        ISLS,

        /// <summary>
        /// land-tied island	a coastal island connected to the mainland by barrier beaches, levees or dikes
        /// </summary>
        ISLT,

        /// <summary>
        /// section of island
        /// </summary>
        ISLX,

        /// <summary>
        /// isthmus	a narrow strip of land connecting two larger land masses and bordered by water
        /// </summary>
        ISTH,

        /// <summary>
        /// karst area	a distinctive landscape developed on soluble rock such as limestone characterized by sinkholes, caves, disappearing streams, and underground drainage
        /// </summary>
        KRST,

        /// <summary>
        /// lava area	an area of solidified lava
        /// </summary>
        LAVA,

        /// <summary>
        /// levee	a natural low embankment bordering a distributary or meandering stream; often built up artificially to control floods
        /// </summary>
        LEV,

        /// <summary>
        /// mesa(s)	a flat-topped, isolated elevation with steep slopes on all sides, less extensive than a plateau
        /// </summary>
        MESA,

        /// <summary>
        /// mound(s)	a low, isolated, rounded hill
        /// </summary>
        MND,

        /// <summary>
        /// moraine	a mound, ridge, or other accumulation of glacial till
        /// </summary>
        MRN,

        /// <summary>
        /// mountain	an elevation standing high above the surrounding area with small summit area, steep slopes and local relief of 300m or more
        /// </summary>
        MT,

        /// <summary>
        /// mountains	a mountain range or a group of mountains or high ridges
        /// </summary>
        MTS,

        /// <summary>
        /// meander neck	a narrow strip of land between the two limbs of a meander loop at its narrowest point
        /// </summary>
        NKM,

        /// <summary>
        /// nunatak	a rock or mountain peak protruding through glacial ice
        /// </summary>
        NTK,

        /// <summary>
        /// nunataks	rocks or mountain peaks protruding through glacial ice
        /// </summary>
        NTKS,

        /// <summary>
        /// pan	a near-level shallow, natural depression or basin, usually containing an intermittent lake, pond, or pool
        /// </summary>
        PAN,

        /// <summary>
        /// pans	a near-level shallow, natural depression or basin, usually containing an intermittent lake, pond, or pool
        /// </summary>
        PANS,

        /// <summary>
        /// pass	a break in a mountain range or other high obstruction, used for transportation from one side to the other [See also gap]
        /// </summary>
        PASS,

        /// <summary>
        /// peninsula	an elongate area of land projecting into a body of water and nearly surrounded by water
        /// </summary>
        PEN,

        /// <summary>
        /// section of peninsula
        /// </summary>
        PENX,

        /// <summary>
        /// peak	a pointed elevation atop a mountain, ridge, or other hypsographic feature
        /// </summary>
        PK,

        /// <summary>
        /// peaks	pointed elevations atop a mountain, ridge, or other hypsographic features
        /// </summary>
        PKS,

        /// <summary>
        /// plateau	an elevated plain with steep slopes on one or more sides, and often with incised streams
        /// </summary>
        PLAT,

        /// <summary>
        /// section of plateau
        /// </summary>
        PLATX,

        /// <summary>
        /// polder	an area reclaimed from the sea by diking and draining
        /// </summary>
        PLDR,

        /// <summary>
        /// plain(s)	an extensive area of comparatively level to gently undulating land, lacking surface irregularities, and usually adjacent to a higher area
        /// </summary>
        PLN,

        /// <summary>
        /// section of plain
        /// </summary>
        PLNX,

        /// <summary>
        /// promontory(-ies)	a bluff or prominent hill overlooking or projecting into a lowland
        /// </summary>
        PROM,

        /// <summary>
        /// point	a tapering piece of land projecting into a body of water, less prominent than a cape
        /// </summary>
        PT,

        /// <summary>
        /// points	tapering pieces of land projecting into a body of water, less prominent than a cape
        /// </summary>
        PTS,

        /// <summary>
        /// beach ridge	a ridge of sand just inland and parallel to the beach, usually in series
        /// </summary>
        RDGB,

        /// <summary>
        /// ridge(s)	a long narrow elevation with steep sides, and a more or less continuous crest
        /// </summary>
        RDGE,

        /// <summary>
        /// stony desert	a desert plain characterized by a surface veneer of gravel and stones
        /// </summary>
        REG,

        /// <summary>
        /// rock	a conspicuous, isolated rocky mass
        /// </summary>
        RK,

        /// <summary>
        /// rockfall	an irregular mass of fallen rock at the base of a cliff or steep slope
        /// </summary>
        RKFL,

        /// <summary>
        /// rocks	conspicuous, isolated rocky masses
        /// </summary>
        RKS,

        /// <summary>
        /// sand area	a tract of land covered with sand
        /// </summary>
        SAND,

        /// <summary>
        /// dry stream bed	a channel formerly containing the water of a stream
        /// </summary>
        SBED,

        /// <summary>
        /// escarpment	a long line of cliffs or steep slopes separating level surfaces above and below
        /// </summary>
        SCRP,

        /// <summary>
        /// saddle	a broad, open pass crossing a ridge or between hills or mountains
        /// </summary>
        SDL,

        /// <summary>
        /// shore	a narrow zone bordering a waterbody which covers and uncovers at high and low water, respectively
        /// </summary>
        SHOR,

        /// <summary>
        /// sinkhole	a small crater-shape depression in a karst area
        /// </summary>
        SINK,

        /// <summary>
        /// slide	a mound of earth material, at the base of a slope and the associated scoured area
        /// </summary>
        SLID,

        /// <summary>
        /// slope(s)	a surface with a relatively uniform slope angle
        /// </summary>
        SLP,

        /// <summary>
        /// spit	a narrow, straight or curved continuation of a beach into a waterbody
        /// </summary>
        SPIT,

        /// <summary>
        /// spur(s)	a subordinate ridge projecting outward from a hill, mountain or other elevation
        /// </summary>
        SPUR,

        /// <summary>
        /// talus slope	a steep concave slope formed by an accumulation of loose rock fragments at the base of a cliff or steep slope
        /// </summary>
        TAL,

        /// <summary>
        /// interdune trough(s)	a long wind-swept trough between parallel longitudinal dunes
        /// </summary>
        TRGD,

        /// <summary>
        /// terrace	a long, narrow alluvial platform bounded by steeper slopes above and below, usually overlooking a waterbody
        /// </summary>
        TRR,

        /// <summary>
        /// upland	an extensive interior region of high land with low to moderate surface relief
        /// </summary>
        UPLD,

        /// <summary>
        /// valley	an elongated depression usually traversed by a stream
        /// </summary>
        VAL,

        /// <summary>
        /// hanging valley	a valley the floor of which is notably higher than the valley or shore to which it leads; most common in areas that have been glaciated
        /// </summary>
        VALG,

        /// <summary>
        /// valleys	elongated depressions usually traversed by a stream
        /// </summary>
        VALS,

        /// <summary>
        /// section of valley
        /// </summary>
        VALX,

        /// <summary>
        /// volcano	a conical elevation composed of volcanic materials with a crater at the top
        /// </summary>
        VLC,

        /// <summary>
        /// apron	a gentle slope, with a generally smooth surface, particularly found around groups of islands and seamounts
        /// </summary>
        APNU,

        /// <summary>
        /// arch	a low bulge around the southeastern end of the island of Hawaii
        /// </summary>
        ARCU,

        /// <summary>
        /// arrugado	an area of subdued corrugations off Baja California
        /// </summary>
        ARRU,

        /// <summary>
        /// borderland	a region adjacent to a continent, normally occupied by or bordering a shelf, that is highly irregular with depths well in excess of those typical of a shelf
        /// </summary>
        BDLU,

        /// <summary>
        /// banks	elevations, typically located on a shelf, over which the depth of water is relatively shallow but sufficient for safe surface navigation
        /// </summary>
        BKSU,

        /// <summary>
        /// bank	an elevation, typically located on a shelf, over which the depth of water is relatively shallow but sufficient for safe surface navigation
        /// </summary>
        BNKU,

        /// <summary>
        /// basin	a depression more or less equidimensional in plan and of variable extent
        /// </summary>
        BSNU,

        /// <summary>
        /// cordillera	an entire mountain system including the subordinate ranges, interior plateaus, and basins
        /// </summary>
        CDAU,

        /// <summary>
        /// canyons	relatively narrow, deep depressions with steep sides, the bottom of which generally has a continuous slope
        /// </summary>
        CNSU,

        /// <summary>
        /// canyon	a relatively narrow, deep depression with steep sides, the bottom of which generally has a continuous slope
        /// </summary>
        CNYU,

        /// <summary>
        /// continental rise	a gentle slope rising from oceanic depths towards the foot of a continental slope
        /// </summary>
        CRSU,

        /// <summary>
        /// deep	a localized deep area within the confines of a larger feature, such as a trough, basin or trench
        /// </summary>
        DEPU,

        /// <summary>
        /// shelf edge	a line along which there is a marked increase of slope at the outer margin of a continental shelf or island shelf
        /// </summary>
        EDGU,

        /// <summary>
        /// escarpment (or scarp)	an elongated and comparatively steep slope separating flat or gently sloping areas
        /// </summary>
        ESCU,

        /// <summary>
        /// fan	a relatively smooth feature normally sloping away from the lower termination of a canyon or canyon system
        /// </summary>
        FANU,

        /// <summary>
        /// flat	a small level or nearly level area
        /// </summary>
        FLTU,

        /// <summary>
        /// fracture zone	an extensive linear zone of irregular topography of the sea floor, characterized by steep-sided or asymmetrical ridges, troughs, or escarpments
        /// </summary>
        FRZU,

        /// <summary>
        /// furrow	a closed, linear, narrow, shallow depression
        /// </summary>
        FURU,

        /// <summary>
        /// gap	a narrow break in a ridge or rise
        /// </summary>
        GAPU,

        /// <summary>
        /// gully	a small valley-like feature
        /// </summary>
        GLYU,

        /// <summary>
        /// hill	an elevation rising generally less than 500 meters
        /// </summary>
        HLLU,

        /// <summary>
        /// hills	elevations rising generally less than 500 meters
        /// </summary>
        HLSU,

        /// <summary>
        /// hole	a small depression of the sea floor
        /// </summary>
        HOLU,

        /// <summary>
        /// knoll	an elevation rising generally more than 500 meters and less than 1,000 meters and of limited extent across the summit
        /// </summary>
        KNLU,

        /// <summary>
        /// knolls	elevations rising generally more than 500 meters and less than 1,000 meters and of limited extent across the summits
        /// </summary>
        KNSU,

        /// <summary>
        /// ledge	a rocky projection or outcrop, commonly linear and near shore
        /// </summary>
        LDGU,

        /// <summary>
        /// levee	an embankment bordering a canyon, valley, or seachannel
        /// </summary>
        LEVU,

        /// <summary>
        /// mesa	an isolated, extensive, flat-topped elevation on the shelf, with relatively steep sides
        /// </summary>
        MESU,

        /// <summary>
        /// mound	a low, isolated, rounded hill
        /// </summary>
        MNDU,

        /// <summary>
        /// moat	an annular depression that may not be continuous, located at the base of many seamounts, islands, and other isolated elevations
        /// </summary>
        MOTU,

        /// <summary>
        /// mountain	a well-delineated subdivision of a large and complex positive feature
        /// </summary>
        MTU,

        /// <summary>
        /// peaks	prominent elevations, part of a larger feature, either pointed or of very limited extent across the summit
        /// </summary>
        PKSU,

        /// <summary>
        /// peak	a prominent elevation, part of a larger feature, either pointed or of very limited extent across the summit
        /// </summary>
        PKU,

        /// <summary>
        /// plain	a flat, gently sloping or nearly level region
        /// </summary>
        PLNU,

        /// <summary>
        /// plateau	a comparatively flat-topped feature of considerable extent, dropping off abruptly on one or more sides
        /// </summary>
        PLTU,

        /// <summary>
        /// pinnacle	a high tower or spire-shaped pillar of rock or coral, alone or cresting a summit
        /// </summary>
        PNLU,

        /// <summary>
        /// province	a region identifiable by a group of similar physiographic features whose characteristics are markedly in contrast with surrounding areas
        /// </summary>
        PRVU,

        /// <summary>
        /// ridge	a long narrow elevation with steep sides
        /// </summary>
        RDGU,

        /// <summary>
        /// ridges	long narrow elevations with steep sides
        /// </summary>
        RDSU,

        /// <summary>
        /// reefs	surface-navigation hazards composed of consolidated material
        /// </summary>
        RFSU,

        /// <summary>
        /// reef	a surface-navigation hazard composed of consolidated material
        /// </summary>
        RFU,

        /// <summary>
        /// rise	a broad elevation that rises gently, and generally smoothly, from the sea floor
        /// </summary>
        RISU,

        /// <summary>
        /// seachannel	a continuously sloping, elongated depression commonly found in fans or plains and customarily bordered by levees on one or two sides
        /// </summary>
        SCNU,

        /// <summary>
        /// seachannels	continuously sloping, elongated depressions commonly found in fans or plains and customarily bordered by levees on one or two sides
        /// </summary>
        SCSU,

        /// <summary>
        /// saddle	a low part, resembling in shape a saddle, in a ridge or between contiguous seamounts
        /// </summary>
        SDLU,

        /// <summary>
        /// shelf	a zone adjacent to a continent (or around an island) that extends from the low water line to a depth at which there is usually a marked increase of slope towards oceanic depths
        /// </summary>
        SHFU,

        /// <summary>
        /// shoal	a surface-navigation hazard composed of unconsolidated material
        /// </summary>
        SHLU,

        /// <summary>
        /// shoals	hazards to surface navigation composed of unconsolidated material
        /// </summary>
        SHSU,

        /// <summary>
        /// shelf valley	a valley on the shelf, generally the shoreward extension of a canyon
        /// </summary>
        SHVU,

        /// <summary>
        /// sill	the low part of a gap or saddle separating basins
        /// </summary>
        SILU,

        /// <summary>
        /// slope	the slope seaward from the shelf edge to the beginning of a continental rise or the point where there is a general reduction in slope
        /// </summary>
        SLPU,

        /// <summary>
        /// seamounts	elevations rising generally more than 1,000 meters and of limited extent across the summit
        /// </summary>
        SMSU,

        /// <summary>
        /// seamount	an elevation rising generally more than 1,000 meters and of limited extent across the summit
        /// </summary>
        SMU,

        /// <summary>
        /// spur	a subordinate elevation, ridge, or rise projecting outward from a larger feature
        /// </summary>
        SPRU,

        /// <summary>
        /// terrace	a relatively flat horizontal or gently inclined surface, sometimes long and narrow, which is bounded by a steeper ascending slope on one side and by a steep descending slope on the opposite side
        /// </summary>
        TERU,

        /// <summary>
        /// tablemounts (or guyots)	seamounts having a comparatively smooth, flat top
        /// </summary>
        TMSU,

        /// <summary>
        /// tablemount (or guyot)	a seamount having a comparatively smooth, flat top
        /// </summary>
        TMTU,

        /// <summary>
        /// tongue	an elongate (tongue-like) extension of a flat sea floor into an adjacent higher feature
        /// </summary>
        TNGU,

        /// <summary>
        /// trough	a long depression of the sea floor characteristically flat bottomed and steep sided, and normally shallower than a trench
        /// </summary>
        TRGU,

        /// <summary>
        /// trench	a long, narrow, characteristically very deep and asymmetrical depression of the sea floor, with relatively steep sides
        /// </summary>
        TRNU,

        /// <summary>
        /// valley	a relatively shallow, wide depression, the bottom of which usually has a continuous gradient
        /// </summary>
        VALU,

        /// <summary>
        /// valleys	a relatively shallow, wide depression, the bottom of which usually has a continuous gradient
        /// </summary>
        VLSU,

        /// <summary>
        /// bush(es)	a small clump of conspicuous bushes in an otherwise bare area
        /// </summary>
        BUSH,

        /// <summary>
        /// cultivated area	an area under cultivation
        /// </summary>
        CULT,

        /// <summary>
        /// forest(s)	an area dominated by tree vegetation
        /// </summary>
        FRST,

        /// <summary>
        /// fossilized forest	a forest fossilized by geologic processes and now exposed at the earth's surface
        /// </summary>
        FRSTF,

        /// <summary>
        /// grassland	an area dominated by grass vegetation
        /// </summary>
        GRSLD,

        /// <summary>
        /// coconut grove	a planting of coconut trees
        /// </summary>
        GRVC,

        /// <summary>
        /// olive grove	a planting of olive trees
        /// </summary>
        GRVO,

        /// <summary>
        /// palm grove	a planting of palm trees
        /// </summary>
        GRVP,

        /// <summary>
        /// pine grove	a planting of pine trees
        /// </summary>
        GRVPN,

        /// <summary>
        /// heath	an upland moor or sandy area dominated by low shrubby vegetation including heather
        /// </summary>
        HTH,

        /// <summary>
        /// meadow	a small, poorly drained area dominated by grassy vegetation
        /// </summary>
        MDW,

        /// <summary>
        /// orchard(s)	a planting of fruit or nut trees
        /// </summary>
        OCH,

        /// <summary>
        /// scrubland	an area of low trees, bushes, and shrubs stunted by some environmental limitation
        /// </summary>
        SCRB,

        /// <summary>
        /// tree(s)	a conspicuous tree used as a landmark
        /// </summary>
        TREE,

        /// <summary>
        /// tundra	a marshy, treeless, high latitude plain, dominated by mosses, lichens, and low shrub vegetation under permafrost conditions
        /// </summary>
        TUND,

        /// <summary>
        /// vineyard	a planting of grapevines
        /// </summary>
        VIN,

        /// <summary>
        /// vineyards	plantings of grapevines
        /// </summary>
        VINS,

        /// <summary>
        /// not available
        /// </summary>
        ll,
    }
}